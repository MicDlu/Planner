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

        public Schedule()
        {
            // init
            foreach (Worker worker in Values.plan.Workers)
                CalcWorkersCapabilities(worker);

            foreach (Shift shift in Values.plan.Shifts)
                CalcShiftCoverage(shift);

            SortShifts();
            SortWorkers();

            // process
            //for (int g = 0; g < 2; g++)
            //{
            //    for (int s = 0; s < shiftsByReserve[g].Count(); )
            //    {
            //        Shift s1 = shiftsByReserve[g].ElementAt(s);
            //        for (int i = 0; i < workersByCapaPriority[g].Count(); i++)
            //        {
            //            Worker w1 = workersByCapaPriority[g].ElementAt(i);
            //            if (w1.CapabilityMap[s1.ProdLineNo, s1.No])
            //            {
            //                s1.AddWorker(w1, (Const.Gender)g);
            //                CalcWorkersCapabilities(w1);
            //                SortWorkers();
            //                CalcShiftCoverage(s1);
            //                SortShifts();
            //                break;
            //            }
            //        }
            //    }
            //}
            for (int s = 0; s < shiftsByReserve[0].Count(); s++)
            {
                Shift s1 = shiftsByReserve[0].ElementAt(s);
                for (int w = 0; w < workersByCapaPriority[0].Count(); w++)
                {
                    //s1 = shiftsByReserve[0].First();
                    Worker w1 = workersByCapaPriority[0].ElementAt(w);
                    if (w1.CapabilityMap[s1.ProdLineNo, s1.No])
                    {
                        s1.AddWorker(w1, (Const.Gender)0);
                        CalcWorkersCapabilities(w1);
                        SortWorkers();
                        CalcShiftCoverage(s1);
                        SortShifts();
                        s1 = shiftsByReserve[0].First();
                        w = -1;
                        s = -1;
                    }
                }
            }
        }

        private void SortWorkers()
        {
            for (int s = 0; s < 2; s++)
                workersByCapaPriority[s] = Values.plan.Workers.Cast<Worker>().ToList()
                    .Where(w => (w.Gender == (Const.Gender)s) && (w.Capabilities() > 0))
                    .OrderBy(o => o.Capabilities())
                    .ThenByDescending(t => t.Priority)
                    .ToList();
        }

        private void SortShifts()
        {
            for (int s = 0; s < 2; s++)
            {
               shiftsByReserve[s] = Values.plan.Shifts.Cast<Shift>().ToList()
                    .Where(w => (w.Gender==(Const.Gender)s) && (w.Order - w.EmployeeAssigned.Count() > 0) && (w.CoverageReserve() > 0))
                    .OrderBy(x => x.CoverageReserve())
                    .ToList();
            }
        }

        void CalcShiftCoverage(Shift shift)
        {
            for (int s = 0; s < 2; s++)
            {
                shift.CoverageCapacity = 0;
                foreach (Worker worker in Values.plan.Workers.Where(x => x.Gender == (Const.Gender)s))
                {
                    shift.CoverageCapacity += worker.CapabilityMap[shift.ProdLineNo,shift.No]?1:0;
                }
            }
        }

        void CalcWorkersCapabilities(Worker worker)
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

        private bool[,] SetDayBreaks(Worker worker)
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

        private bool SetBreak(bool[,] db, int d, int s)
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
