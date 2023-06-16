using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SD = System.Data;
using ExcelDataReader;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Security.AccessControl;

namespace zadanie2_shvets
{
    static class PhoneBookLoader
    {
        public static void Load(PhoneBook phoneBook, string fileName,DataGridView table) 
        {
            try
            {
                table.RowCount = 1;
                FileStream stream = File.Open($@"{fileName}", FileMode.Open, FileAccess.Read);
                var reader = ExcelReaderFactory.CreateReader(stream);
                do
                {
                    while (reader.Read())
                    {
                        table.Rows.Add(reader.GetString(0), reader.GetString(1));
                    }
                } while (reader.NextResult());
                stream.Close();
            }
            catch
            {
                MessageBox.Show("Такого файла нет");
            }
        }
        public static void Save(PhoneBook phoneBook, string fileName,DataGridView table)
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook book = exApp.Workbooks.Add(Type.Missing);
            book.SaveAs($"{fileName}.xlsx");

            for (int i = 0; i<table.RowCount-1; i++) 
            { 
                for(int j = 0; j<table.ColumnCount; j++) 
                {
                    exApp.Cells[i + 1, j + 1] = table[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
        }
    }
}
