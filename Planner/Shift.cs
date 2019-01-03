using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    class Shift
    {
        public int No { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int ProdLineNo { get; set; }
        public DateTime Date { get; set; }
        public int Planned { get; set; }
        public List<Employee> EmployeeAssigned { get; set; }

        public Shift(int day, int hour, int prodLineNo, int planned)
        {
            No = 3 * day + hour;
            Day = day;
            Hour = hour;
            ProdLineNo = prodLineNo;
            Planned = planned;
            EmployeeAssigned = new List<Employee>();
        }
    }
}
