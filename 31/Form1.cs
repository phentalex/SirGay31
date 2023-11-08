using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sirgay31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double xStart = Double.Parse(textBox1.Text);
            double xEnd = Double.Parse(textBox2.Text);
            double dx = Double.Parse(textBox3.Text);
            double y, r = 3;

            dataGridView1.AllowUserToAddRows = false;
            DataTable table = new DataTable();

            table.Rows.Clear();
            table.Columns.Clear();
            table.Columns.Add("X", typeof(string));
            table.Columns.Add("Y", typeof(string));
            dataGridView1.DataSource = table;

            if (xStart > xEnd)
            {
                double temp = xStart;
                xStart = xEnd;
                xEnd = temp;
            }

            double x = xStart;


            if (x >= -7 && x <= 11)
            {
                if (x <= -3)
                {
                    for (int i = 0; x <= -3 && x <= xEnd; i++)
                    {
                        y = 3;
                        table.Rows.Add(x, y);
                        x += dx;
                    }
                }
                if (x <= 0)
                {
                    for (int i = 0; x <= 0 && x <= xEnd; i++)
                    {
                        y = Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x, 2)) - 3;
                        table.Rows.Add(x, Math.Round(-y, 6));
                        x += dx;
                    }
                }
                if (x <= 3)
                {
                    for (int i = 0; x <= 3 && x <= xEnd; i++)
                    {
                        y = Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x, 2)) - 3;
                        table.Rows.Add(x, Math.Round(-y, 6));
                        x += dx;
                    }
                }
                if (x <= 6)
                {
                    for (int i = 0; x <= 6 && x <= xEnd; i++)
                    {
                        y = -2 * x + 9;
                        table.Rows.Add(x, Math.Round(y, 6));
                        x += dx;
                    }
                }
                if (x <= 11)
                {
                    for (int i = 0; x <= 11 && x <= xEnd; i++)
                    {
                        y = x - 9;
                        table.Rows.Add(x, Math.Round(y, 6));
                        x += dx;
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите значения Х от -7 до 11! (0_0)", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
