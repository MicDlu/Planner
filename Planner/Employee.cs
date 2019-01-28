using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public Const.Sex Sex { get; set; }
        public string DisplayName { get; set; }
        public DateTime AvailableFrom { get; set; }
        public DateTime AvailableTo { get; set; }
        public int Priority { get; set; }
        public DateShift LastShift { get; set; }
        public DateTime LastFreeDay { get; set; }
        public DateTime LastFreeSunday { get; set; }
        public bool[,] WeekDisposition { get; set; }
        public bool[,] FixedPerDay { get; set; }


        public Worker(int id, string name, string lastname, Const.Sex sex)
        {
            Id = id;
            Name = name;
            Lastname = lastname;
            DisplayName = name + " " + lastname;
            Sex = sex;

            AvailableFrom = new DateTime();
            AvailableTo = new DateTime();
            Priority = 1;
            //LastShift = new DateShift() { date = new DateTime(), shift = 0 };
            //LastFreeDay = new DateTime();
            //LastFreeSunday = new DateTime();
            WeekDisposition = new bool[Const.WorkDays, Const.ShiftsPerDay];
            FixedPerDay = new bool[Const.WorkDays, Const.ShiftsPerDay];

        }

        public string DispositionToText(bool[,] disposition)
        {
            string result = string.Empty;
            for (int r = 0; r < disposition.GetLength(0); r++)
            {
                for (int c = 0; c < disposition.GetLength(1); c++)
                {
                    result += disposition[r, c] ? "1" : "0";
                    if (c+1 < disposition.GetLength(1))
                        result += ",";
                }
                if (r+1 < disposition.GetLength(0))
                    result += ";";
            }
            return result;
        }

        public struct DateShift
        {
            public DateTime date;
            public int shift;
        }
    }
}
