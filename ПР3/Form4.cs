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
    public partial class Form4 : Form
    {
        public double Row { get; private set; }
        public Form4(int i, int j)
        {
            InitializeComponent();
            labelString.Text = "Строка " + (i+1).ToString();
            labelElement.Text= (j+1).ToString() + " элемент";
        }

        private void textBoxNumber_TextChanged(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 45)
            {
                e.Handled = true;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                bool exit = true;
                if (String.IsNullOrEmpty(textBoxNumber.Text))
                {
                    errorProvider1.SetError(textBoxNumber, "Поле должно быть заполненно");
                    exit = false;
                }
                else
                {
                    errorProvider1.Clear();
                    exit = true;
                }
                if (exit)
                {
                    Row = Convert.ToDouble(textBoxNumber.Text);
                    Close();
                }
            }
            catch(FormatException)
            {
                errorProvider1.SetError(textBoxNumber, "Поле должно иметь число");
            }
        }
    }
}
