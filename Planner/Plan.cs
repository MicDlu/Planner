using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    class Plan
    {
        public Shift[,] Shifts { get; set; }
        public DateTime WeekStart { get; set; }
        public String[] ProductionLines { get; set; }
        public DateTime[] Week { get; set; }

        public Plan()
        {
            Week = InitWeek();
            ProductionLines = InitProductionLines(false);
            Shifts = new Shift[Constants.ProductionLinesCount, Constants.GridRowsCount];
            for (int p = 0; p < Constants.ProductionLinesCount; p++)
            {
                for (int d = 0; d < Constants.WorkDays; d++)
                {
                    for (int h = 0; h < Constants.ShiftsPerDay; h++)
                    {
                        Shift shift = new Shift(d, h, p, 3);
                        Shifts[p, Constants.ShiftsPerDay * d + h] = shift;
                    }
                }
            }
        }

        public Plan(string filename)
        {
            filename = @"C:\Users\micha\Documents\Planer Manpower\PLANER 2018 t.38.xlsm";
            ExcelInterop excel = new ExcelInterop(filename);
            excel.SetWeekCellRange("E6");

            ProductionLines = InitProductionLines(true);
            Shifts = new Shift[Constants.ProductionLinesCount, Constants.GridRowsCount];
            for (int p = 0; p < Constants.ProductionLinesCount; p++)
            {
                for (int d = 0; d < Constants.WorkDays; d++)
                {
                    for (int h = 0; h < Constants.ShiftsPerDay; h++)
                    {
                        Shift shift = new Shift(d, h, p, Constants.WorkDays);
                        Shifts[p, Constants.ShiftsPerDay * d + h] = shift;
                    }
                }
            }
        }

        private string[] InitProductionLines(bool open)
        {
            if (open)
                return Constants.ProductionLines;
            String[] newProductionLines = new string[Constants.ProductionLinesCount];
            for (int i = 0; i < Constants.ProductionLinesCount; i++)
            {
                newProductionLines[i] = "Production Line " + (i+1).ToString();
            }
            return newProductionLines;
        }

        private DateTime[] InitWeek()
        {
            DateTime[] newWeek = new DateTime[Constants.WorkDays];
            newWeek[0] = new DateTime(2018, 12, 24);
            for (int i = 1; i < Constants.WorkDays; i++)
            {
                newWeek[i] = newWeek[0].AddDays(i);
            }
            return newWeek;
        }
    }
}
