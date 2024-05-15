using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР3
{
    public partial class Form3 : Form
    {
        public int Row = 0, Column = 0, Columning = 0, Rowing = 0;
        public Form3(int Columning, int Rowing)
        {
            this.Columning = Columning;
            this.Rowing = Rowing;
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Row = Rowing;
            Column = Columning;
            Close();
        }

        private void textBoxColumn_TextChanged(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        protected void textBoxRow_TextChanged(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        public void buttonOk_Click(object sender, EventArgs e)
        {
            bool exit = false;
            bool exit1 = false;
            if (String.IsNullOrEmpty(textBoxColumn.Text))
            {
                errorProvider1.SetError(textBoxColumn, "Поле должно быть заполненно");
                exit = false;
            }
            else
            if (textBoxColumn.Text == "0")
            {
                errorProvider1.SetError(textBoxColumn, "Ни один размер матрицы не может быть равен 0");
                exit = false;
            }
            else
            {
                errorProvider1.Clear();
                exit = true;
            }
            if (String.IsNullOrEmpty(textBoxRow.Text))
            {
                errorProvider2.SetError(textBoxRow, "Поле должно быть заполненно");
                exit1 = false;
            }
            else
            if (textBoxRow.Text == "0")
            {
                errorProvider2.SetError(textBoxRow, "Ни один размер матрицы не может быть равен 0");
                exit1 = false;
            }
            else
            {
                errorProvider2.Clear();
                exit1 = true;
            }
            if (exit & exit1)
            {
                Row = Convert.ToInt32(textBoxRow.Text);
                Column = Convert.ToInt32(textBoxColumn.Text);
                Close();
            }
        }
    }
}