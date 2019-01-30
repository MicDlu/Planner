using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    public class Schedule
    {
        private List<Shift>[] shiftsByReserve = new List<Shift>[2];
        private List<Worker>[] workersByCapaPriority = new List<Worker>[2];
        public static int[,,] initialShiftCoverage = new int[Const.ProductionLinesCount, Const.GridRowsCount,2];
        public static List<bool[,]> initialWorkerCoverage = new List<bool[,]>();

        public Schedule()
        {
            // init
            foreach (Worker worker in Values.plan.Workers)
            {
                CalcWorkersCapabilities(worker);
                initialWorkerCoverage.Add(worker.CapabilityMap);
            }

            foreach (Shift shift in Values.plan.Shifts)
            {
                CalcShiftCoverage(shift);
                initialShiftCoverage[shift.ProdLineNo, shift.No, (int)shift.Gender] = shift.CoverageCapacity;
            }

            SortShifts(0);
            SortShifts(1);
            SortWorkers(0);
            SortWorkers(1);

            // process

            for (int g = 0; g < 2; g++)
            {
                bool finish = false;
                for (int s = 0; s < shiftsByReserve[g].Count(); s++)
                {
                    Shift s1 = shiftsByReserve[g].ElementAt(s);
                    for (int w = 0; w < workersByCapaPriority[g].Count(); w++)
                    {
                        //s1 = shiftsByReserve[0].First();
                        Worker w1 = workersByCapaPriority[g].ElementAt(w);
                        if (w1.CapabilityMap[s1.ProdLineNo, s1.No])
                        {
                            s1.AddWorker(w1, (Const.Gender)g);
                            CalcWorkersCapabilities(w1);
                            SortWorkers(g);
                            CalcShiftCoverage(s1);
                            SortShifts(g);
                            w = -1;
                            s = -1;
                            if (!(finish = shiftsByReserve[g].Count() == 0))
                                s1 = shiftsByReserve[g].First();
                        }
                        if (finish)
                            break;
                    }
                    if (finish)
                        break;
                }
                if (finish)
                    continue;
            }
        }

        private void SortWorkers(int gender)
        {
            //for (int s = 0; s < 2; s++)
                workersByCapaPriority[gender] = Values.plan.Workers.Cast<Worker>().ToList()
                    .Where(w => (w.Gender == (Const.Gender)gender) && (w.Capabilities() > 0))
                    .OrderBy(o => o.Capabilities())
                    .ThenByDescending(t => t.Priority)
                    .ToList();
        }

        private void SortShifts(int gender)
        {
            //for (int s = 0; s < 2; s++)
            //{
               shiftsByReserve[gender] = Values.plan.Shifts.Cast<Shift>().ToList()
                    .Where(w => (w.Gender==(Const.Gender)gender) &&
                    (w.Order - w.EmployeeAssigned.Count() > 0))
                    .OrderBy(x => x.CoverageReserve())
                    .ToList();
            //}
        }

        static public void CalcShiftCoverage(Shift shift)
        {
            shift.CoverageCapacity = 0;
            foreach (Worker worker in Values.plan.Workers.Where(x => x.Gender == shift.Gender))
            {
                shift.CoverageCapacity += worker.CapabilityMap[shift.ProdLineNo,shift.No]?1:0;
            }
        }

        static public void CalcWorkersCapabilities(Worker worker)
        {
            worker.CapabilityMap = new bool[Const.ProductionLinesCount, Const.GridRowsCount];
            bool[,] dayBreaks = SetDayBreaks(worker);

            for (int d = 0; d < Const.WorkDays; d++)
            {
                for (int s = 0; s < Const.ShiftsPerDay; s++)
                {
                    for (int p = 0; p < Const.ProductionLinesCount; p++)
                    {
                        bool condDayBreaks = !dayBreaks[d, s];
                        bool condDayCheck = (worker.WeekDisposition != null) ? (worker.WeekDisposition[d, s]) : (worker.FixedPerDay[d, s]);
                        bool condProductionCheck = worker.ProductionsCheck[p];
                        bool condFrom = (!worker.AvailableFrom.active) || (Values.plan.Week[d] >= worker.AvailableFrom.date);
                        bool condTo = (!worker.AvailableTo.active) || (Values.plan.Week[d] <= worker.AvailableTo.date);
                        bool condLastShift = 2 < ((Values.plan.Week[d] - worker.LastShift.date).Days * Const.ShiftsPerDay + (s - worker.LastShift.shift));
                        bool condLastFreeDay = (d >= 6) || (6 >= ((Values.plan.Week[d] - worker.LastFreeDay).Days));
                        bool condLastFreeSunday = (d != 6) || (3 >= ((Values.plan.Week[d] - worker.LastFreeSunday).Days / 7));

                        worker.CapabilityMap[p, d * Const.ShiftsPerDay + s] = condDayBreaks && condDayCheck && condProductionCheck && condFrom && condFrom && condTo && condLastShift && condLastFreeDay && condLastFreeSunday;
                    }
                }
            }
        }

        static public bool[,] SetDayBreaks(Worker worker)
        {
            bool[,] dayBreaks = new bool[Const.WorkDays, Const.ShiftsPerDay];
            foreach (Shift shift in worker.ShiftsAssigned)
            {
                dayBreaks[shift.Day, shift.Hour] = true;
                switch (shift.Hour)
                {
                    case 0:
                        SetBreak(dayBreaks, shift.Day - 1, 1);
                        SetBreak(dayBreaks, shift.Day - 1, 2);
                        SetBreak(dayBreaks, shift.Day, 1);
                        SetBreak(dayBreaks, shift.Day, 2);
                        break;
                    case 1:
                        SetBreak(dayBreaks, shift.Day - 1, 2);
                        SetBreak(dayBreaks, shift.Day, 2);
                        SetBreak(dayBreaks, shift.Day, 0);
                        SetBreak(dayBreaks, shift.Day + 1, 0);
                        break;
                    case 2:
                        SetBreak(dayBreaks, shift.Day, 0);
                        SetBreak(dayBreaks, shift.Day, 1);
                        SetBreak(dayBreaks, shift.Day + 1, 0);
                        SetBreak(dayBreaks, shift.Day + 1, 1);
                        break;
                    default:
                        break;
                }
            }
            return dayBreaks;
        }

        static public bool SetBreak(bool[,] db, int d, int s)
        {
            if (d < 0 || d > 6)
                return false;
            db[d, s] = true;
            return true;
        }

        public static void PrintShifts(int gender)
        {
            for (int i = 0; i < Values.plan.Shifts.GetLength(0); i++)
            {
                for (int j = 0; j < Values.plan.Shifts.GetLength(1); j++)
                {
                    Console.Write(Values.plan.Shifts[i, j, gender].CoverageReserve() + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
