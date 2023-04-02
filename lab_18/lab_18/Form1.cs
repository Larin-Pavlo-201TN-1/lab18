/*
Варіант 10
1. В одномірному масиві, що складається з n дійсних елементів, розрахувати:
а) кількість елементів масиву, що лежать в діапазоні від А до B;
б) суму елементів масиву, розташованих після максимального елемента.
Упорядкувати елементи масиву за убуванням модулів елементів.
Результати всіх розрахунків і перетворень масиву вивести на консоль.
2. Даний двовимірний масив цілих чисел. Вияснити:
а) чи є непарні числа у верхньому правому і нижньому правому куті;
б) чи є числа, що закінчуються цифрою 5, у верхньому лівому або
нижньому лівому куті. Масив вивести на консоль.
*/

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

namespace lab_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


           
        }

        private void arr_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (e.KeyChar == ';')
            {
                return;
            }

            e.Handled = true;
        }

        private void min_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            e.Handled = true;
        }

        private void max_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] sign = new char[] { ';' };
            string[] arr = arr_txt.Text.Split(sign, StringSplitOptions.RemoveEmptyEntries);
            int min = 0;
            int max = 100;
            int counter = 0;
            int max_i = 0;
            int sum = 0;
            if (min_txt.Text != "")
                min = Convert.ToInt32(min_txt.Text);
            if (max_txt.Text != "")
                max = Convert.ToInt32(max_txt.Text);
            if (min > max)
            {
                int tmp = max;
                max = min;
                min = tmp;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (min <= Convert.ToInt32(arr[i]) && max >= Convert.ToInt32(arr[i]))
                    counter++;
            }

            if(arr_txt.Text != "")
                max = Convert.ToInt32(arr[0]);
            for(int i = 0; i < arr.Length; i++)
            {
                if(max <= Convert.ToInt32(arr[i]))
                {
                    max_i = i + 1;
                    max = Convert.ToInt32(arr[i]);
                }
            }
            for(int i = max_i; i < arr.Length; i++)
            {
                sum += Convert.ToInt32(arr[i]);
            }

            max = 0;
            string t = "";

            for (int i = 0; i < arr.Length; i++)
            {
                max = i;
                for (int j = i + 1; j < arr.Length; j++)
                    max = (Convert.ToInt32(arr[j]) > Convert.ToInt32(arr[max])) ? j : max;
                if (i != max)
                {
                    t = arr[i];
                    arr[i] = arr[max];
                    arr[max] = t;
                }
            }

            rezult1.Text = counter.ToString();
            rezult2.Text = sum.ToString();
            rezult3.Text = "";
            for (int i = 0; i < arr.Length; i++)
            {
                rezult3.Text += arr[i] + "; ";
            }
        }

        private void x_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            e.Handled = true;
        }

        private void y_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int column = 3;
            int row = 3;
            if (x_txt.Text != "")
                row = Convert.ToInt32(x_txt.Text);
            if (y_txt.Text != "")
                column = Convert.ToInt32(y_txt.Text);
            dataGridView1.AllowUserToAddRows = false;
            DataTable table = new DataTable();
            for(int i = 0; i < column; i++)
            {
                table.Columns.Add(i.ToString(), typeof(string));
            }
            for (int i = 0; i < row; i++)
            {
                table.Rows.Add(new string[] { });
            }
            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[dataGridView1.ColumnCount, dataGridView1.RowCount];
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    arr[i, j] = dataGridView1[i, j].Value.ToString() == "" ? 0 : Convert.ToInt32(dataGridView1[i, j].Value.ToString());
                }
            }

            if (dataGridView1.ColumnCount >= 0 && dataGridView1.RowCount >= 0)
                dataGridView2.AllowUserToAddRows = false;
            DataTable table = new DataTable();
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                table.Columns.Add(i.ToString(), typeof(string));
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                table.Rows.Add();
            }
            dataGridView2.DataSource = table;
            for (int i = 0; i < dataGridView2.ColumnCount; i++)
            {
                for(int j = 0; j < dataGridView2.RowCount; j++)
                {
                    dataGridView2[i,j].Value = arr[i, j];
                }
            }

            if (arr[dataGridView2.ColumnCount - 1, 0] % 2 != 0 && arr[dataGridView2.ColumnCount - 1, dataGridView2.RowCount - 1] % 2 != 0)
                rezult4.Text = "Так";
            else
                rezult4.Text = "Ні";

            if (arr[0, 0].ToString()[arr[0, 0].ToString().Length - 1] == '5' && arr[0, dataGridView2.RowCount - 1].ToString()[arr[0, 0].ToString().Length - 1] == '5')
                rezult5.Text = "Так";
            else
                rezult5.Text = "Ні";
        }
    }
}