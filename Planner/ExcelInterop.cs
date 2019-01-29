using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Planner
{
    public class ExcelInterop
    {
        Excel.Application excelApp;
        Excel.Workbook excelWorkbook;
        Excel.Worksheet excelWorksheetOrder;
        private string FileName { get; set; }
        public Excel.Range CellRange { get; set; }
        public int[] weekRangeSize = { 84, 21 };

        public ExcelInterop(string filename)
        {
            FileName = filename;
            using (ProcessingForm processingForm = new ProcessingForm(OpenFile))
            {
                processingForm.ShowDialog();
            }
        }

        private void OpenFile()
        {
            excelApp = new Excel.Application();
            excelWorkbook = excelApp.Workbooks.Open(FileName);
            excelWorksheetOrder = excelWorkbook.Worksheets["Zamówienie"];
        }

        public void SetWeekCellRange(string cellBegin, string cellEnd = null)
        {
            if (cellEnd == null)
                CellRange = excelWorksheetOrder.Range[cellBegin].Resize[weekRangeSize[0], weekRangeSize[1]];
            else
                CellRange = excelWorksheetOrder.Range[cellBegin, cellEnd];
        }

        public int[,] ExtractRangeValues()
        {
            object[,] objectValues = (object[,])CellRange.get_Value(Excel.XlRangeValueDataType.xlRangeValueDefault);
            int[,] integerValues = new int[objectValues.GetLength(0), objectValues.GetLength(1)];

            for (int i=0; i< objectValues.GetLength(0); i++)
            {
                for (int j = 0; j < objectValues.GetLength(1); j++)
                {
                    if (objectValues[i + 1, j + 1] == null)
                        integerValues[i, j] = 0;
                    else
                    {
                        string value = objectValues[i + 1, j + 1].ToString();
                        if (!int.TryParse(value, out integerValues[i, j]))
                            integerValues[i, j] = 0;
                    }
                    
                }
            }
            return integerValues;
        }

        public void FindWeekRangeByDate()
        {
            // StartDate -> WeekCellRange
        }

        public void Close()
        {
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorksheetOrder);
            excelWorkbook.Close(excelWorkbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorkbook);
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        }

        public void KillAllExcelProcesses()
        {
            System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName("Excel");
            foreach (System.Diagnostics.Process p in process)
            {
                if (!string.IsNullOrEmpty(p.ProcessName))
                {
                    try
                    {
                        p.Kill();
                    }
                    catch { }
                }
            }
        }
    }
}
