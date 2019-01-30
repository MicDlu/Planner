using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    public class Schedule
    {
        List<Shift>[] sortedShifts = new List<Shift>[2];

        public Schedule()
        {
            foreach (Worker worker in Values.plan.Workers)
            {
                CalcWorkersCapabilities(worker);
            }

            foreach (Shift shift in Values.plan.Shifts)
            {
                CalcShiftCoverage(shift);
            }

            SortShifts();
        }

        private void SortShifts()
        {
            for (int s = 0; s < 2; s++)
            {
               sortedShifts[s] = Values.plan.Shifts.Cast<Shift>().ToList().Where(w => w.PerSex[s].sex == (Const.Sex)s).OrderBy(x => x.PerSex[s].CoverageReserve()).ToList();
            }
        }

        void CalcShiftCoverage(Shift shift)
        {
            for (int s = 0; s < 2; s++)
            {
                shift.PerSex[s].coverageCapacity = 0;
                foreach (Worker worker in Values.plan.Workers.Where(x => x.Sex == (Const.Sex)s))
                {
                    shift.PerSex[s].coverageCapacity += worker.CapabilityMap[shift.ProdLineNo,shift.No]?1:0;
                }
            }
        }

        void CalcWorkersCapabilities(Worker worker)
        {
            worker.CapabilityMap = new bool[Const.ProductionLinesCount,Const.GridRowsCount];
            for (int d = 0; d < Const.WorkDays; d++)
            {
                for (int s = 0; s < Const.ShiftsPerDay; s++)
                {
                    for (int p = 0; p < Const.ProductionLinesCount; p++)
                    {
                        bool condDayCheck = (worker.WeekDisposition != null) ? (worker.WeekDisposition[d, s]) : (worker.FixedPerDay[d, s]);
                        bool condProductionCheck = worker.ProductionsCheck[p];
                        bool condFrom = (!worker.AvailableFrom.active) || (Values.plan.Week[d] >= worker.AvailableFrom.date);
                        bool condTo = (!worker.AvailableTo.active) || (Values.plan.Week[d] <= worker.AvailableTo.date);
                        bool condLastShift = 2 < ((Values.plan.Week[d] - worker.LastShift.date).Days * Const.ShiftsPerDay + (s - worker.LastShift.shift));
                        bool condLastFreeDay = (d >= 6) || (6 >= ((Values.plan.Week[d] - worker.LastFreeDay).Days));
                        bool condLastFreeSunday = (d!=6) || ( 3 >= ((Values.plan.Week[d] - worker.LastFreeSunday).Days / 7));

                        worker.CapabilityMap[p, d * Const.ShiftsPerDay + s] = condDayCheck && condProductionCheck && condFrom && condFrom && condTo && condLastShift && condLastFreeDay && condLastFreeSunday;
                    }
                }
            }
        }

        public static void PrintShifts(int sex)
        {
            for (int i = 0; i < Values.plan.Shifts.GetLength(0); i++)
            {
                for (int j = 0; j < Values.plan.Shifts.GetLength(1); j++)
                {
                    Console.Write(Values.plan.Shifts[i, j].PerSex[sex].CoverageReserve() + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
