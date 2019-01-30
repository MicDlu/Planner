using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    public class Schedule
    {

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
        }

        void CalcShiftCoverage(Shift shift)
        {

        }

        void CalcWorkersCapabilities(Worker worker)
        {
            bool[,] capa = new bool[Const.ProductionLinesCount,Const.GridRowsCount];
            bool[,] allow;
            // check
            if (worker.WeekDisposition != null)
                allow = worker.WeekDisposition;
            else
                allow = worker.FixedPerDay;
            for (int d = 0; d < Const.WorkDays; d++)
            {
                for (int s = 0; s < Const.ShiftsPerDay; s++)
                {
                    for (int p = 0; p < Const.ProductionLinesCount; p++)
                    {
                        bool condDayCheck = allow[d, s];
                        bool condFrom = (!worker.AvailableFrom.active) || (Values.plan.Week[d] >= worker.AvailableFrom.date);
                        bool condTo = (!worker.AvailableTo.active) || (Values.plan.Week[d] <= worker.AvailableTo.date);
                        bool condLastShift = 2 < ((Values.plan.Week[d] - worker.LastShift.date).Days * Const.ShiftsPerDay + (s - worker.LastShift.shift));
                        bool condLastFreeDay = 6 >= ((Values.plan.Week[d] - worker.LastFreeDay).Days);
                        bool condLastFreeSunday = (d!=6) || ( 3 >= ((Values.plan.Week[d] - worker.LastFreeSunday).Days / 7));

                        capa[p, d * Const.ShiftsPerDay + s] = condDayCheck && condFrom && condFrom && condTo && condLastShift && condLastFreeDay && condLastFreeSunday;
                    }
                }
            }
        }
    }
}
