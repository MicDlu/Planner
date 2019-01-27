using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    static class Constants
    {
        public const int ProductionLinesCount = 12;
        public static readonly string[] ProductionLines = { "C650", "Czekolada", "Eclairs", "Green&Black", "Magazyn Opak.", "Magazyn Sur.", "Mignonnettes", "Mini Eggs", "MWG", "Myjnia", "Pakowalnia", "S&C"};
        public const int ShiftsPerDay = 3;
        public const int WorkDays = 7;
        public const int GridColumnsCount = ProductionLinesCount;
        public const int GridRowsCount = ShiftsPerDay * WorkDays;
    }
}
