using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, res;
            double x, y, res2;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                res = a + b;
                MessageBox.Show("Результат: " + res.ToString());
            }
            else if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y))
            {
                res2 = x + y;
                MessageBox.Show("Результат: " + res2.ToString());
            }           
            else
            {
                MessageBox.Show("Неверные аргументы", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, res;
            double x, y, res2;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                res = a - b;
                MessageBox.Show("Результат: " + res.ToString());
            }
            else if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y))
            {
                res2 = x - y;
                MessageBox.Show("Результат: " + res2.ToString());
            }
            else
            {
                MessageBox.Show("Неверные аргументы", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, res;
            double x, y, res2;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                res = a * b;
                MessageBox.Show("Результат: " + res.ToString());
            }
            else if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y))
            {
                res2 = x * y;
                MessageBox.Show("Результат: " + res2.ToString());
            }
            else
            {
                MessageBox.Show("Неверные аргументы", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x, y, res;
            if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y))
            {
                res = x / y;
                MessageBox.Show("Результат: " + res.ToString());
            }
            else
            {
                MessageBox.Show("Неверные аргументы", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a, b;
            double x, y;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                if (a == b)
                {
                    MessageBox.Show("chisla ravni");
                }
                else
                {
                    MessageBox.Show("chisla ne ravni");
                }
            }
            else if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y))
            {
                if (x == y)
                {
                    MessageBox.Show("chisla ravni");
                }
                else
                {
                    MessageBox.Show("chisla ne ravni");
                }
            }
            else
            {
                MessageBox.Show("Неверные аргументы", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a, b;
            double x, y;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                if (a > b)
                {
                    MessageBox.Show(a.ToString() + ">" + b.ToString());
                }
                else
                {
                    MessageBox.Show(b.ToString() + ">" + a.ToString());
                }
            }
            else if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y))
            {
                if (x > y)
                {
                    MessageBox.Show(x.ToString() + ">" + y.ToString());
                }
                else
                {
                    MessageBox.Show(y.ToString() + ">" + x.ToString());
                }
            }
            else
            {
                MessageBox.Show("Неверные аргументы", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int a, b;
            double x, y;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                if (a < b)
                {
                    MessageBox.Show(a.ToString() + "<" + b.ToString());
                }
                else
                {
                    MessageBox.Show(b.ToString() + "<" + a.ToString());
                }
            }
            else if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y))
            {
                if (x < y)
                {
                    MessageBox.Show(x.ToString() + "<" + y.ToString());
                }
                else
                {
                    MessageBox.Show(y.ToString() + "<" + x.ToString());
                }
            }
            else
            {
                MessageBox.Show("Неверные аргументы", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a, b;
            double x, y;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                if (a >= b)
                {
                    MessageBox.Show(a.ToString() + ">=" + b.ToString());
                }
                else
                {
                    MessageBox.Show(b.ToString() + ">=" + a.ToString());
                }
            }
            else if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y))
            {
                if (x >= y)
                {
                    MessageBox.Show(x.ToString() + ">=" + y.ToString());
                }
                else
                {
                    MessageBox.Show(y.ToString() + ">=" + x.ToString());
                }
            }
            else
            {
                MessageBox.Show("Неверные аргументы", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int a, b;
            double x, y;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                if (a <= b)
                {
                    MessageBox.Show(a.ToString() + "<=" + b.ToString());
                }
                else
                {
                    MessageBox.Show(b.ToString() + "<=" + a.ToString());
                }
            }
            else if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y))
            {
                if (x <= y)
                {
                    MessageBox.Show(x.ToString() + "<=" + y.ToString());
                }
                else
                {
                    MessageBox.Show(y.ToString() + "<=" + x.ToString());
                }
            }
            else
            {
                MessageBox.Show("Неверные аргументы", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int a, b, res;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                res = a & b;
                MessageBox.Show("Результат: " + res.ToString());
            }           
            else
            {
                MessageBox.Show("Неверные аргументы", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int a, b, res;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                res = a | b;
                MessageBox.Show("Результат: " + res.ToString());
            }
            else
            {
                MessageBox.Show("Неверные аргументы", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int a, b, res;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                res = a ^ b;
                MessageBox.Show("Результат: " + res.ToString());
            }
            else
            {
                MessageBox.Show("Неверные аргументы", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int a, res;
            if (int.TryParse(textBox1.Text, out a) && textBox2.Text == "")
            {
                res =  ~ a;
                MessageBox.Show("Результат: " + res.ToString());
            }
            else
            {
                MessageBox.Show("Неверные аргументы", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int a;
            double x;
            if (int.TryParse(textBox1.Text, out a) && textBox2.Text == "")
            {
                    MessageBox.Show("Результат: " + Math.Asin(a).ToString());
             
            }
            else if (double.TryParse(textBox1.Text, out x) && textBox2.Text == "")
            {
                MessageBox.Show("Результат: " + Math.Asin(x).ToString());
            }
            else
            {
                MessageBox.Show("Неверные аргументы", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int a;
            double x;
            if (int.TryParse(textBox1.Text, out a) && textBox2.Text == "")
            {
                MessageBox.Show("Результат: " + Math.Atan(a).ToString());

            }
            else if (double.TryParse(textBox1.Text, out x) && textBox2.Text == "")
            {
                MessageBox.Show("Результат: " + Math.Atan(x).ToString());
            }
            else
            {
                MessageBox.Show("Неверные аргументы", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double a, b, res;
            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b))
            {
                res = Math.Pow(b, 1 / a);
                MessageBox.Show("Результат: " + res.ToString());
            }
            else
            {
                MessageBox.Show("Неверные аргументы", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double x, y, res;
            if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y))
            {
                res = x % y;
                MessageBox.Show("Результат: " + res.ToString());
            }
            else
            {
                MessageBox.Show("Неверные аргументы", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double a;
            if (double.TryParse(textBox1.Text, out a) && textBox2.Text == "")
            {
                if (Math.Truncate(Math.Log(a, 4)) == (Math.Log(a, 4)))
                {
                    MessageBox.Show("da");
                }       
                else
                    MessageBox.Show("da");
            }
            else
            {
                MessageBox.Show("Неверные аргументы", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
    
