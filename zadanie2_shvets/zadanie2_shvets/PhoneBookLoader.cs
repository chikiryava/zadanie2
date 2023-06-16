using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ExcelDataReader;
using static System.Data.IDataReader;
using System.Windows.Forms;

namespace zadanie2_shvets
{
    static class PhoneBookLoader
    {
        public static void Load(PhoneBook phoneBook, string fileName,DataGridView table) 
        {
            table.RowCount = 1;
            FileStream stream = File.Open(@"C:\Users\chiki\OneDrive\Документы\numbers.xlsx", FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateReader(stream);
            do
            {
                while (reader.Read())
                {
                    table.Rows.Add(reader.GetString(0),reader.GetString(1));
                }
            } while (reader.NextResult());
            stream.Close();
        }
        static void Save(PhoneBook phoneBook, string fileName)
        {
        }
    }
}
