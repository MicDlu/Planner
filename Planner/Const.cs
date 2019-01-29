using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    static public class Const
    {
        public const int ProductionLinesCount = 12;
        public static readonly string[] ProductionLines = { "C650", "Czekolada", "Eclairs", "Green&Black", "Magazyn Opak.", "Magazyn Sur.", "Mignonnettes", "Mini Eggs", "MWG", "Myjnia", "Pakowalnia", "S&C" };
        public const int ShiftsPerDay = 3;
        public const int WorkDays = 7;
        public static readonly string[] Days = { "Poniedziałek", "Wtorek", "Środa", "Czwartek", "Piątek", "Sobota", "Niedziela" };
        public const int SexTypes = 2;
        public enum Sex { Male, Female };
        public const int GridColumnsCount = ProductionLinesCount;
        public const int GridRowsCount = ShiftsPerDay * WorkDays;
        public const int PriorityRange = 3;
        public static readonly string systemUIDateFormat = System.Globalization.CultureInfo.CurrentUICulture.DateTimeFormat.ShortDatePattern;
        public static readonly ExcelFields excelFields = new ExcelFields() { ID = 1, NAME = 2, LASTNAME = 3, GENDER = 4, PRIORITY = 5, FROM = 6, TO = 7, LASTSHIFT = 8, LASTFREEDAY = 9, LASTFREESUNDAY = 10, THISWEEK = 11, FIXEDWEEK = 12, FIXEDPRODUCTION = 13 };
    }

    static public class Values
    {
        public static DateTime[] Week { get; set; }
        public static Plan plan;
    }

    class ComboBoxItem
    {
        public string Name;
        public int Value;

        public override string ToString()
        {
            return Name;
        }
    }

    public struct ExcelFields
    {
        public int ID;
        public int NAME;
        public int LASTNAME;
        public int GENDER;
        public int PRIORITY;
        public int FROM;
        public int TO;
        public int LASTSHIFT;
        public int LASTFREEDAY;
        public int LASTFREESUNDAY;
        public int THISWEEK;
        public int FIXEDWEEK;
        public int FIXEDPRODUCTION;
    }
}
