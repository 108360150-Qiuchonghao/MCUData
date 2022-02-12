﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;


namespace MouseUI
{
    class Excel
    {
        String path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public Excel(string path, int Sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = excel.Worksheets[Sheet];
        }

        public string ReadCell(int i ,int j )
        {
            i++;
            j++;
            if (ws.Cells[i, j].Value2 != null)
                return ws.Cells[i, j].Value2;
            else
                return "";
        }
        public void WriteToCell(int i ,int j , string s)
        {
            i++;
            j++;
            ws.Cells[i, j].Value2 = s;

        }
        public void WriteppgToCell(int i, int j, string s)
        {
            i++;
            j++;
            ws.Cells[i, j].Value2 = s;

        }

        public void Save() 
        {
            wb.Save();    
        }
        public void SaveAs(string path)
        {
            wb.SaveAs(path);
        }
        public void close()
        {
            wb.Close();
        }

    }
}
