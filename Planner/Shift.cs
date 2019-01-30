using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    public class Shift
    {
        public int No { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int ProdLineNo { get; set; }
        public DateTime Date { get; set; }
        public Const.Gender Gender { get; set; }
        public int Order { get; set; }
        public List<Worker> EmployeeAssigned { get; set; }
        public int CoverageCapacity { get; set; }

        public int CoverageReserve()
        {
            return CoverageCapacity - (Order - EmployeeAssigned.Count);
        }

        public Shift(int day, int hour, int prodLineNo, Const.Gender gender, int order)
        {
            No = Const.ShiftsPerDay * day + hour;
            Day = day;
            Hour = hour;
            ProdLineNo = prodLineNo;
            Gender = gender;
            Order = order;
            EmployeeAssigned = new List<Worker>();
        }

        public bool AddWorker(Worker worker, Const.Gender targetGender)
        {
            if (EmployeeAssigned.Count < Order)
            {
                EmployeeAssigned.Add(worker);
                worker.ShiftsAssigned.Add(this);
                return true;
            }
            return false;
        }

        public bool RemoveWorker(Worker worker, Const.Gender targetGender)
        {
            if (EmployeeAssigned.Count > 0)
            {
                EmployeeAssigned.Remove(worker);
                worker.ShiftsAssigned.Remove(this);
                return true;
            }
            return false;
        }
    }
}
