﻿using System;
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
        public static readonly ExcelFields excelFields = new ExcelFields() { ID = 0, NAME = 1, LASTNAME = 2, GENDER = 3, PRIORITY = 4, FROM = 5, TO = 6, LASTSHIFT = 7, LASTFREEDAY = 8, LASTFREESUNDAY = 9, THISWEEK = 10, FIXEDWEEK = 11, FIXEDPRODUCTION = 12 };
        public const int attributeCount = 13;
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
