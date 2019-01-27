using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Planner
{
    class ExcelInterop
    {
        Excel.Application excelApp;
        Excel.Workbook excelWorkbook;
        Excel.Worksheet excelWorksheetOrder;
        private string FileName { get; set; }
        public DateTime StartDate { get; set; }
        public Excel.Range WeekCellRange { get; set; }
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
                WeekCellRange = excelWorksheetOrder.Range[cellBegin].Resize[weekRangeSize[0], weekRangeSize[1]];
            else
                WeekCellRange = excelWorksheetOrder.Range[cellBegin, cellEnd];
        }

        public void ProcessOrder()
        {

        }

        public void FindWeekRangeByDate()
        {
            // StartDate -> WeekCellRange
        }

        //public void ProcessOrder()
        //{
        //    const int dateRow = 5;
        //    const int dateColumnStart = 6;
        //    const int dateColumnStep = 21;
        //    excelWorksheetOrder = excelWorkbook.Worksheets["Zamówienie"];
        //    if (StartDate == null)
        //    {
        //        // choose last week
        //    }
        //    else
        //    {
        //        // set week by date
        //        string formattedStartDate = StartDate.ToString("dd.MM.yyyy");
        //        string cellValue;
        //        int dateColumn = 1;
        //        do
        //        {
        //            cellValue = excelWorksheetOrder.Cells[dateRow, dateColumn].Value2.ToString();
        //            dateColumn += 1;
        //        } while (cellValue != formattedStartDate);
        //    }
        //}

        public void Close()
        {
            excelWorkbook.Close(excelWorkbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorkbook);
        }
    }
}
