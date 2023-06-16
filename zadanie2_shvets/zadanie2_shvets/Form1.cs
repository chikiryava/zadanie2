using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie2_shvets
{
    public partial class Form1 : Form
    {
        PhoneBook phone_book = new PhoneBook();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhoneBookLoader.Load(phone_book,"",dataGridView1);
        }

        private void findForNameButton_Click(object sender, EventArgs e)
        {
            phone_book.FindForName(nameTextBox.Text,dataGridView1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private bool CheckNumber(string number)
        {
            if (number[])
        }
    }
}
