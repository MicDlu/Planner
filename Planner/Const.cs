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

        //public struct Sexes
        //{
        //    public const Sex MALE = Sex.Male;
        //    public const Sex FEMALE = Sex.Female;
        //}


    }

    static public class Values
    {
        public static DateTime[] Week { get; set; }
    }

    class ComboBoxItem
    {
        public string Name;
        public int Value;
        public ComboBoxItem(string name, int value)
        {
            Name = name;
            Value = value;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}