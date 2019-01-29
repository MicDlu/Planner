using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    public class Plan
    {
        public Shift[,] Shifts { get; set; }
        public DateTime WeekStart { get; set; }
        public String[] ProductionLines { get; set; }
        public DateTime[] Week { get; set; }
        private ExcelInterop Excel;
        public List<Worker> Workers { get; set; }

        public Plan(string filename)
        {
            ProductionLines = InitProductionLines(true);
            Week = InitWeek();
            Excel = new ExcelInterop(filename);
        }

        public void ExtractOrderAmountsFromRange(string cellBegin, string cellEnd = null)
        {
            Excel.SetWeekCellRange(cellBegin,cellEnd);
            int[,] rawOrder = Excel.ExtractRangeValues();

            Shifts = new Shift[Const.ProductionLinesCount, Const.GridRowsCount];
            for (int p = 0; p < Const.ProductionLinesCount; p++)
            {
                for (int d = 0; d < Const.WorkDays; d++)
                {
                    for (int s = 0; s < Const.ShiftsPerDay; s++)
                    {
                        Shift shift = new Shift(d, s, p);

                        int rawRow = p * 7 + s * 2;
                        int rawCol = d * 3;
                        shift.SetOrderPerSex(Const.Sex.Female, rawOrder[rawRow,rawCol]);
                        shift.SetOrderPerSex(Const.Sex.Male, rawOrder[rawRow + 1, rawCol]);

                        Shifts[p, Const.ShiftsPerDay * d + s] = shift;
                    }
                }
            }
        }

        public void CloseExcel(bool save)
        {
            Excel.Close(save);
            // Excel.KillAllExcelProcesses();
        }

        public void SaveWorkersToFile()
        {
            Excel.SaveWorkers(Workers);
        }

        private string[] InitProductionLines(bool open)
        {
            if (open)
                return Const.ProductionLines;
            String[] newProductionLines = new string[Const.ProductionLinesCount];
            for (int i = 0; i < Const.ProductionLinesCount; i++)
            {
                newProductionLines[i] = "Production Line " + (i+1).ToString();
            }
            return newProductionLines;
        }

        private DateTime[] InitWeek()
        {
            DateTime[] newWeek = new DateTime[Const.WorkDays];
            newWeek[0] = new DateTime(2018, 12, 24);
            for (int i = 1; i < Const.WorkDays; i++)
            {
                newWeek[i] = newWeek[0].AddDays(i);
            }
            Values.Week = newWeek;
            return newWeek;
        }
    }
}
