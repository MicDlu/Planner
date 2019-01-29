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
        Excel.Worksheet excelWorksheetWorkers;
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
            excelWorksheetWorkers = excelWorkbook.Worksheets["Pracownicy"];
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

        internal void SaveWorkers(List<Worker> workers)
        {
            for (int a = 0; a < Const.attributeCount; a++)
            {
                excelWorksheetWorkers.Cells[1, a + 1] = Const.excelFields[a];
            }
            for (int i = 0; i < workers.Count; i++)
            {
                List<string> attributes = workers[i].ToExcelFormat();
                for (int a = 0; a < attributes.Count; a++)
                {
                    excelWorksheetWorkers.Cells[i + 2, a + 1] = attributes[a];
                }
            }

            //excelWorkbook.SaveAs(GetFileDirectory(FileName) + "\\test", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
            //    false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
            //    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }

        public List<Worker> LoadWorkers()
        {
            List<Worker> workers = new List<Worker>();
            int row = 2;
            while ((excelWorksheetWorkers.Cells[row, 1] as Excel.Range).Value2 != null)
            {
                List<string> attributes = new List<string>();
                Excel.Range RowRange = (excelWorksheetWorkers.Cells[row++, 1] as Excel.Range).Resize[1, Const.attributeCount];
                object[,] objectValues = (object[,])RowRange.get_Value(Excel.XlRangeValueDataType.xlRangeValueDefault);

                for (int i = 0; i < Const.attributeCount; i++)
                {
                    attributes.Add(objectValues[1,i+1]==null?string.Empty:objectValues[1, i + 1].ToString());
                }
                workers.Add(new Worker(attributes));
            }
            return workers;
        }

        public void FindWeekRangeByDate()
        {
            // StartDate -> WeekCellRange
        }

        public void Close(bool save = false)
        {
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorksheetOrder);
            if (save)
                try
                {
                    excelWorkbook.Save();
                }
                catch (System.Runtime.InteropServices.COMException e)
                {

                }
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

        private string GetFileDirectory(string filepath)
        {
            return filepath.Substring(0, filepath.LastIndexOf('\\'));
        }
    }
}
