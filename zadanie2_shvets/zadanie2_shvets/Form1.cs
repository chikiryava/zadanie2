﻿using System;
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
            if (CheckNumber(numberTextBox.Text))
            {
                phone_book.AddUser(addNameTextBox.Text,numberTextBox.Text,dataGridView1);
            }
        }
        private bool CheckNumber(string number)
        {
            try
            {
                if (number.Length != 14)
                {
                    throw new Exception("Вы ввели не все символы в номере");
                }
                if (number[0] != '(')
                {
                    throw new Exception("Неправильный формат номера");
                }
                if (number[4] != ')')
                {
                    throw new Exception("Неправильный формат номера");
                }
                if (number[8] != '-')
                {
                    throw new Exception("Неправильный формат номера");
                }
                if (number[11] != '-')
                {
                    throw new Exception("Неправильный формат номера");
                }
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            phone_book.RemoveUser(dataGridView1.SelectedRows[0].Index, dataGridView1);
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            PhoneBookLoader.Save(phone_book, "meow", dataGridView1);
        }
    }
}
