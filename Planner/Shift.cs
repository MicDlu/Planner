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
        public OrderPerSex[] PerSex { get; set; }
        //public int Order { get; set; }
        //public List<Employee> EmployeeAssigned { get; set; }

        public Shift(int day, int hour, int prodLineNo)
        {
            No = Const.ShiftsPerDay * day + hour;
            Day = day;
            Hour = hour;
            ProdLineNo = prodLineNo;
            PerSex = new OrderPerSex[2];
            //Order = order;
            //EmployeeAssigned = new List<Employee>();
        }

        public void SetOrderPerSex(Const.Sex sex, int order)
        {
            PerSex[(int)sex].sex = sex;
            PerSex[(int)sex].order = order;
            PerSex[(int)sex].employeeAssigned = new List<Worker>();
        }

        public bool AddWorker(Worker worker, Const.Sex targetSex)
        {
            if (PerSex[(int)worker.Sex].employeeAssigned.Count < PerSex[(int)targetSex].order)
            {
                PerSex[(int)targetSex].employeeAssigned.Add(worker);
                return true;
            }
            return false;
        }

        public bool RemoveWorker(Worker worker, Const.Sex targetSex)
        {
            if (PerSex[(int)targetSex].employeeAssigned.Count > 0)
            {
                PerSex[(int)targetSex].employeeAssigned.Remove(worker);
                return true;
            }
            return false;
        }

        public struct OrderPerSex
        {
            public Const.Sex sex;
            public int order;
            public List<Worker> employeeAssigned;
            public int coverageCapacity;
        }
    }
}
