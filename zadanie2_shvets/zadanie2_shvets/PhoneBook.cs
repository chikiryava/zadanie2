using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie2_shvets
{
    internal class PhoneBook
    {
        public void FindForName(string name,DataGridView table)
        {
            for(int i = 0;  i < table.Rows.Count-1; i++)
            {
                if (table[0,i].Value.ToString().Contains(name))
                {
                    table[0,i].Selected = true;
                }
                else
                    table[0, i].Selected = false;

            }
        }
        public void AddUser(string name,string phonenumber,DataGridView table)
        {
            pho
        }
    }
}
