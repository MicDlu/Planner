using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    class Plan
    {
        public Shift[,] Shifts { get; set; }
        public DateTime WeekStart { get; set; }
        public String[] ProductionLines { get; set; }

        public Plan(String[] productionLines)
        {
            ProductionLines = productionLines;
            Shifts = new Shift[productionLines.Count(), 7 * 3];
            for (int p = 0; p < ProductionLines.Count(); p++)
            {
                for (int d = 0; d < 7; d++)
                {
                    for (int h = 0; h < 3; h++)
                    {
                        Shift shift = new Shift(d, h, p, 3);
                        Shifts[p, 3 * d + h] = shift;
                    }
                }
            }
        }
    }
}
