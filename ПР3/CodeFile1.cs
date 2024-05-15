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
        /// <summary>
        /// перебор строчки и вывод числа положительных
        /// </summary>
        static public string CountPositiveElements<T>(T rows,int columns)
        {
            dynamic row = rows;
            int x = columns, z = x, y = x;
            for (int j = 0; j < columns; j++)
            {
                if (Convert.ToDouble(row.Cells[j].Value) <= 0)
                    z--;
                if (Convert.ToDouble(row.Cells[j].Value) == 0)
                    y--;
            }
            if (x != z && y!=0)
                return "Положительно чисел: " + z.ToString();
            else if (y==0)
                return "Все числа равны 0";
            else
                return "Все числа положительные";
        }
    }
}