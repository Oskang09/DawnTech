using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace DawnTech
{
    public class ExcelReader
    {
        // Excel not zero based
        private Application App { get; set; }
        private Workbook Workbook { get; set; }
        private _Worksheet WorkSheet { get; set; }
        private Range Range { get; set; }

        public ExcelReader(string file)
        {
            App = new Application();
            Workbook = App.Workbooks.Open(file);
        }

        public List<string> getSheets()
        {
            var lists = new List<string>();

            for (int i = 1; i < Workbook.Sheets.Count + 1; i++)
            {
                _Worksheet wd = Workbook.Sheets[i];
                lists.Add(wd.Name);
            }
            return lists;
        }

        public WorkData readExcel(int sheets)
        {
            WorkData tle = new WorkData();
            tle.Holidays = new List<DateTime>();
            _Worksheet Ws = Workbook.Sheets[sheets];

            Range xlR = Ws.UsedRange;

            int rowC = xlR.Rows.Count;
            int colC = xlR.Columns.Count;

            string[] date = Parser.readCell(xlR, 3, 3).Split('~');
            tle.When = Parser.readStringToDateTime(date[0]);

            List<ExcelData> data = new List<ExcelData>();
            int start_row = 5;
            for (int sr = start_row; sr < rowC; sr += 2)
            {
                data.Add(new ExcelData()
                {
                    UID = Parser.readCell(xlR, sr, 3),
                    CheckIn = Parser.readStringToCheckIn(xlR, sr + 1, tle.When)
                });
            }
            tle.ExcelData = data;
            return tle;
        }

        public void close()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Workbook.Close(0);
            Marshal.FinalReleaseComObject(Workbook);
            App.Quit();
            Marshal.FinalReleaseComObject(App);
        }
    }
}
