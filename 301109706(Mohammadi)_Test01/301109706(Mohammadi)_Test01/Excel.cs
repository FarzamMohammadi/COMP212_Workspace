using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace _301109706_Mohammadi__Test01
{
    class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;


        public Excel(string path, int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
        }

        public string ReadCell(int row, int column)
        {
            row++;
            column++;
            if (ws.Cells[row, column].Value2 != null)
            {
                return ws.Cells[row, column].Value.ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
