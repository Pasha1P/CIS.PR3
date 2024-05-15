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
    public partial class ПР3 : Form
    {
        public ПР3()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 0;
            dataGridView1.RowCount = 0;
        }
        /// <summary>
        /// открытие формы "о программе"
        /// </summary>
        private void Programm_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        /// <summary>
        /// открытие формы "Изменение размеров матрицы" и изменение размеров матрицы
        /// </summary>
        private void Size_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 form3 = new Form3(dataGridView1.ColumnCount, dataGridView1.RowCount);
                form3.ShowDialog();
                if (dataGridView1.ColumnCount != form3.Column || dataGridView1.RowCount != form3.Row)
                {
                    dataGridView1.ColumnCount = 0;
                    dataGridView1.RowCount = 0;
                    dataGridView1.ColumnCount = form3.Column;
                    dataGridView1.RowCount = form3.Row;
                    dataGridView1.RowHeadersVisible = false;
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Количество колонок должно быть от 1 до 100 000", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Количество колонок должно быть от 1 до 655", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        /// <summary>
        /// открытие формы "Заполнение матрицы"
        /// </summary>
        private void Completion_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("Матрица должна иметь размер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        Form4 form4 = new Form4(i, j);
                        form4.ShowDialog();
                        dataGridView1.Rows[i].Cells[j].Value = form4.Row;
                    }
                }
            }
        }
        /// <summary>
        /// подсчет количества положительных чисел
        /// </summary>
        private void buttonWrite_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1 || dataGridView1.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Матрица должна иметь размер и быть заполнена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridView1.RowHeadersVisible = true;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].HeaderCell.Value = CountPositiveElements(dataGridView1.Rows[i], dataGridView1.Columns.Count);
                }
            }
        }
    }
}