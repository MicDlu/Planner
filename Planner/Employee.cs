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
        public string LastShiftt { get; set; } // DDMMYYYY-S (S=1/2/3)
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
        }
    }
}
