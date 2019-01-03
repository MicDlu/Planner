using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string DisplayName { get; set; }
        public List<Plan> ShiftPlanned { get; set; }

        public Employee(int id, string name, string lastname)
        {
            Id = id;
            Name = name;
            Lastname = lastname;
            DisplayName = name + " " + lastname;
        }
    }
}
