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
                listBox1.Items.Insert(0, a.ToString() + "+" + b.ToString() + "=" + res.ToString());
            }
            else if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y))
            {
                res2 = x + y;
                listBox1.Items.Insert(0, x.ToString() + "+" + y.ToString() + "=" + res2.ToString());
            }
            else if (!double.TryParse(textBox1.Text, out x) && (int.TryParse(textBox2.Text, out b) || double.TryParse(textBox2.Text, out y)) && textBox1.Text != "")
            {
                MessageBox.Show("первый аргумент не число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!double.TryParse(textBox2.Text, out y) && (int.TryParse(textBox1.Text, out b) || double.TryParse(textBox1.Text, out y)) && textBox2.Text != "")
            {
                MessageBox.Show("второй аргумент не число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text != "" && double.TryParse(textBox2.Text, out x))
            {
                MessageBox.Show("вы не ввели первое число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "" && textBox1.Text != "" && double.TryParse(textBox1.Text, out x))
            {
                MessageBox.Show("вы не ввели второе число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("вы не ввели оба числа", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("оба аргумента не явл числами", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, res;
            double x, y, res2;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                res = a - b;
                listBox1.Items.Insert(0, a.ToString() + "-" + b.ToString() + "=" + res.ToString());
            }
            else if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y))
            {
                res2 = x - y;
                listBox1.Items.Insert(0, x.ToString() + "-" + y.ToString() + "=" + res2.ToString());
            }
            else if (!double.TryParse(textBox1.Text, out x) && (int.TryParse(textBox2.Text, out b) || double.TryParse(textBox2.Text, out y)) && textBox1.Text != "")
            {
                MessageBox.Show("первый аргумент не число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!double.TryParse(textBox2.Text, out y) && (int.TryParse(textBox1.Text, out b) || double.TryParse(textBox1.Text, out y)) && textBox2.Text != "")
            {
                MessageBox.Show("второй аргумент не число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text != "" && double.TryParse(textBox2.Text, out x))
            {
                MessageBox.Show("вы не ввели первое число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "" && textBox1.Text != "" && double.TryParse(textBox1.Text, out x))
            {
                MessageBox.Show("вы не ввели второе число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("вы не ввели оба числа", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("оба аргумента не явл числами", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, res;
            double x, y, res2;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                res = a * b;
                listBox1.Items.Insert(0, a.ToString() + "*" + b.ToString() + "=" + res.ToString());
            }
            else if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y))
            {
                res2 = x * y;
                listBox1.Items.Insert(0, x.ToString() + "*" + y.ToString() + "=" + res2.ToString());
            }
            else if (!double.TryParse(textBox1.Text, out x) && (int.TryParse(textBox2.Text, out b) || double.TryParse(textBox2.Text, out y)) && textBox1.Text != "")
            {
                MessageBox.Show("первый аргумент не число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!double.TryParse(textBox2.Text, out y) && (int.TryParse(textBox1.Text, out b) || double.TryParse(textBox1.Text, out y)) && textBox2.Text != "")
            {
                MessageBox.Show("второй аргумент не число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text != "" && double.TryParse(textBox2.Text, out x))
            {
                MessageBox.Show("вы не ввели первое число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "" && textBox1.Text != "" && double.TryParse(textBox1.Text, out x))
            {
                MessageBox.Show("вы не ввели второе число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("вы не ввели оба числа", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("оба аргумента не явл числами", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x, y, res;
            if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y))
            {
                if (y != 0)
                {
                    res = x / y;
                    listBox1.Items.Insert(0, x.ToString() + "/" + y.ToString() + "=" + res.ToString());
                }
                else
                {
                    MessageBox.Show("на 0 делить нельзя", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y) && textBox1.Text != "")
            {
                MessageBox.Show("первый аргумент не число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!double.TryParse(textBox2.Text, out y) && double.TryParse(textBox1.Text, out x) && textBox2.Text != "")
            {
                MessageBox.Show("второй аргумент не число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text != "" && double.TryParse(textBox2.Text, out x))
            {
                MessageBox.Show("вы не ввели первое число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "" && textBox1.Text != "" && double.TryParse(textBox1.Text, out x))
            {
                MessageBox.Show("вы не ввели второе число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("вы не ввели оба числа", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("оба аргумента не явл числами", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    listBox1.Items.Insert(0, a.ToString() + "=" + b.ToString() + "?" + "     da");
                }
                else
                {
                    listBox1.Items.Insert(0, a.ToString() + "=" + b.ToString() + "?" + "     net");
                }
            }
            else if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y))
            {
                if (x == y)
                {
                    listBox1.Items.Insert(0, x.ToString() + "=" + y.ToString() + "?" + "     da");
                }
                else
                {
                    listBox1.Items.Insert(0, x.ToString() + "=" + y.ToString() + "?" + "     net");
                }
            }
            else if (!double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y) && textBox1.Text != "")
            {
                MessageBox.Show("первый аргумент не число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!double.TryParse(textBox2.Text, out y) && double.TryParse(textBox1.Text, out x) && textBox2.Text != "")
            {
                MessageBox.Show("второй аргумент не число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text != "" && double.TryParse(textBox2.Text, out x))
            {
                MessageBox.Show("вы не ввели первое число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "" && textBox1.Text != "" && double.TryParse(textBox1.Text, out x))
            {
                MessageBox.Show("вы не ввели второе число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("вы не ввели оба числа", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("оба аргумента не явл числами", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    listBox1.Items.Insert(0, a.ToString() + ">" + b.ToString() + "?"  + "     da");
                }
                else
                {
                    listBox1.Items.Insert(0, a.ToString() + ">" + b.ToString() + "?" + "     net");
                }
            }
            else if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y))
            {
                if (x > y)
                {
                    listBox1.Items.Insert(0, x.ToString() + ">" + y.ToString() + "?" + "     da");
                }
                else
                {
                    listBox1.Items.Insert(0, x.ToString() + ">" + y.ToString() + "?" + "     net");
                }
            }
            else if (!double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y) && textBox1.Text != "")
            {
                MessageBox.Show("первый аргумент не число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!double.TryParse(textBox2.Text, out y) && double.TryParse(textBox1.Text, out x) && textBox2.Text != "")
            {
                MessageBox.Show("второй аргумент не число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text != "" && double.TryParse(textBox2.Text, out x))
            {
                MessageBox.Show("вы не ввели первое число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "" && textBox1.Text != "" && double.TryParse(textBox1.Text, out x))
            {
                MessageBox.Show("вы не ввели второе число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("вы не ввели оба числа", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("оба аргумента не явл числами", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    listBox1.Items.Insert(0, a.ToString() + "<" + b.ToString() + "?" + "     da");
                }
                else
                {
                    listBox1.Items.Insert(0, a.ToString() + "<" + b.ToString() + "?" + "     net");
                }
            }
            else if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y))
            {
                if (x < y)
                {
                    listBox1.Items.Insert(0, x.ToString() + "<" + y.ToString() + "?" + "     da");
                }
                else
                {
                    listBox1.Items.Insert(0, x.ToString() + "<" + y.ToString() + "?" + "     net");
                }
            }
            else if (!double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y) && textBox1.Text != "")
            {
                MessageBox.Show("первый аргумент не число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!double.TryParse(textBox2.Text, out y) && double.TryParse(textBox1.Text, out x) && textBox2.Text != "")
            {
                MessageBox.Show("второй аргумент не число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text != "" && double.TryParse(textBox2.Text, out x))
            {
                MessageBox.Show("вы не ввели первое число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "" && textBox1.Text != "" && double.TryParse(textBox1.Text, out x))
            {
                MessageBox.Show("вы не ввели второе число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("вы не ввели оба числа", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("оба аргумента не явл числами", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    listBox1.Items.Insert(0, a.ToString() + ">=" + b.ToString() + "?" + "     da");
                }
                else
                {
                    listBox1.Items.Insert(0, a.ToString() + ">=" + b.ToString() + "?" + "     net");
                }
            }
            else if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y))
            {
                if (x >= y)
                {
                    listBox1.Items.Insert(0, x.ToString() + ">" + y.ToString() + "?" + "     da");
                }
                else
                {
                    listBox1.Items.Insert(0, x.ToString() + ">" + y.ToString() + "?" + "     net");
                }
            }
            else if (!double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y) && textBox1.Text != "")
            {
                MessageBox.Show("первый аргумент не число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!double.TryParse(textBox2.Text, out y) && double.TryParse(textBox1.Text, out x) && textBox2.Text != "")
            {
                MessageBox.Show("второй аргумент не число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text != "" && double.TryParse(textBox2.Text, out x))
            {
                MessageBox.Show("вы не ввели первое число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "" && textBox1.Text != "" && double.TryParse(textBox1.Text, out x))
            {
                MessageBox.Show("вы не ввели второе число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("вы не ввели оба числа", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("оба аргумента не явл числами", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    listBox1.Items.Insert(0, a.ToString() + "<=" + b.ToString() + "?" + "     da");
                }
                else
                {
                    listBox1.Items.Insert(0, a.ToString() + "<=" + b.ToString() + "?" + "     net");
                }
            }
            else if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y))
            {
                if (x <= y)
                {
                    listBox1.Items.Insert(0, x.ToString() + "<=" + y.ToString() + "?" + "     da");
                }
                else
                {
                    listBox1.Items.Insert(0, x.ToString() + "<=" + y.ToString() + "?" + "     da");
                }
            }
            else if (!double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y) && textBox1.Text != "")
            {
                MessageBox.Show("первый аргумент не число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!double.TryParse(textBox2.Text, out y) && double.TryParse(textBox1.Text, out x) && textBox2.Text != "")
            {
                MessageBox.Show("второй аргумент не число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text != "" && double.TryParse(textBox2.Text, out x))
            {
                MessageBox.Show("вы не ввели первое число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "" && textBox1.Text != "" && double.TryParse(textBox1.Text, out x))
            {
                MessageBox.Show("вы не ввели второе число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("вы не ввели оба числа", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("оба аргумента не явл числами", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int a, b, res;
            bool x, y, res2;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                res = a & b;
                listBox1.Items.Insert(0, a.ToString() + "&" + b.ToString() + "=" + res.ToString());
            }
            else if (bool.TryParse(textBox1.Text, out x) && bool.TryParse(textBox2.Text, out y))
            {
                res2 = x & y;
                listBox1.Items.Insert(0, x.ToString() + " & " + y.ToString() + "=" + res2.ToString());
            }
            else if (textBox1.Text == "" && textBox2.Text != "")
            {
                MessageBox.Show("вы не ввели первый аргумент", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "" && textBox1.Text != "")
            {
                MessageBox.Show("вы не ввели второй аргумент", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("вы не ввели оба аргумента", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(textBox2.Text, out a) && !bool.TryParse(textBox2.Text, out x) && (int.TryParse(textBox1.Text, out a) || bool.TryParse(textBox1.Text, out x)))
            {
                MessageBox.Show("второй аргумент не число и не логическая переменная", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(textBox1.Text, out a) && !bool.TryParse(textBox1.Text, out x) && (int.TryParse(textBox2.Text, out a) || bool.TryParse(textBox2.Text, out x)))
            {
                MessageBox.Show("первый аргумент не число и не логическая переменная", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(textBox1.Text, out a) && !bool.TryParse(textBox1.Text, out x) && !int.TryParse(textBox2.Text, out a) && !bool.TryParse(textBox2.Text, out x))
            {
                MessageBox.Show("оба аргумента не число и не логическая переменная", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.TryParse(textBox1.Text, out a) && bool.TryParse(textBox2.Text, out x))
            {
                MessageBox.Show("нельзя сравнивать логический и числовой тип данных", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.TryParse(textBox2.Text, out a) && bool.TryParse(textBox1.Text, out x))
            {
                MessageBox.Show("нельзя сравнивать логический и числовой тип данных", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            int a, b, res;
            bool x, y, res2;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                res = a | b;
                listBox1.Items.Insert(0, a.ToString() + " | " + b.ToString() + "=" + res.ToString());
            }
            else if (bool.TryParse(textBox1.Text, out x) && bool.TryParse(textBox2.Text, out y))
            {
                res2 = x | y;
                listBox1.Items.Insert(0, x.ToString() + " | " + y.ToString() + "=" + res2.ToString());
            }
            else if (textBox1.Text == "" && textBox2.Text != "")
            {
                MessageBox.Show("вы не ввели первый аргумент", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "" && textBox1.Text != "")
            {
                MessageBox.Show("вы не ввели второй аргумент", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("вы не ввели оба аргумента", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(textBox2.Text, out a) && !bool.TryParse(textBox2.Text, out x) && (int.TryParse(textBox1.Text, out a) || bool.TryParse(textBox1.Text, out x)))
            {
                MessageBox.Show("второй аргумент не число и не логическая переменная", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(textBox1.Text, out a) && !bool.TryParse(textBox1.Text, out x) && (int.TryParse(textBox2.Text, out a) || bool.TryParse(textBox2.Text, out x)))
            {
                MessageBox.Show("первый аргумент не число и не логическая переменная", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(textBox1.Text, out a) && !bool.TryParse(textBox1.Text, out x) && !int.TryParse(textBox2.Text, out a) && !bool.TryParse(textBox2.Text, out x))
            {
                MessageBox.Show("оба аргумента не число и не логическая переменная", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.TryParse(textBox1.Text, out a) && bool.TryParse(textBox2.Text, out x))
            {
                MessageBox.Show("нельзя сравнивать логический и числовой тип данных", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.TryParse(textBox2.Text, out a) && bool.TryParse(textBox1.Text, out x))
            {
                MessageBox.Show("нельзя сравнивать логический и числовой тип данных", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int a, b, res;
            bool x, y, res2;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                res = a ^ b;
                listBox1.Items.Insert(0, a.ToString() + " ^ " + b.ToString() + "=" + res.ToString());
            }
            else if (bool.TryParse(textBox1.Text, out x) && bool.TryParse(textBox2.Text, out y))
            {
                res2 = x ^ y;
                listBox1.Items.Insert(0, x.ToString() + " ^ " + y.ToString() + "=" + res2.ToString());
            }
            else if (textBox1.Text == "" && textBox2.Text != "")
            {
                MessageBox.Show("вы не ввели первый аргумент", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "" && textBox1.Text != "")
            {
                MessageBox.Show("вы не ввели второй аргумент", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("вы не ввели оба аргумента", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(textBox2.Text, out a) && !bool.TryParse(textBox2.Text, out x) && (int.TryParse(textBox1.Text, out a) || bool.TryParse(textBox1.Text, out x)))
            {
                MessageBox.Show("второй аргумент не число и не логическая переменная", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(textBox1.Text, out a) && !bool.TryParse(textBox1.Text, out x) && (int.TryParse(textBox2.Text, out a) || bool.TryParse(textBox2.Text, out x)))
            {
                MessageBox.Show("первый аргумент не число и не логическая переменная", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(textBox1.Text, out a) && !bool.TryParse(textBox1.Text, out x) && !int.TryParse(textBox2.Text, out a) && !bool.TryParse(textBox2.Text, out x))
            {
                MessageBox.Show("оба аргумента не число и не логическая переменная", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.TryParse(textBox1.Text, out a) && bool.TryParse(textBox2.Text, out x))
            {
                MessageBox.Show("нельзя сравнивать логический и числовой тип данных", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.TryParse(textBox2.Text, out a) && bool.TryParse(textBox1.Text, out x))
            {
                MessageBox.Show("нельзя сравнивать логический и числовой тип данных", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int a;
            bool x;
            if (int.TryParse(textBox1.Text, out a) && textBox2.Text == "")
            {
                listBox1.Items.Insert(0," ~" + a.ToString() + "=" + (~ a).ToString());
            }
            else if (bool.TryParse(textBox1.Text, out x) && textBox2.Text == "")
            {
                listBox1.Items.Insert(0, " ~" + x.ToString() + "=" + (!x).ToString());
            }
            else if ((int.TryParse(textBox1.Text, out a) || bool.TryParse(textBox1.Text, out x)) && textBox2.Text != "")
            {
                MessageBox.Show("введите аргумент только в первое окно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text != "")
            {
                MessageBox.Show("введите аргумент в первое поле", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("введите аргумент", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!bool.TryParse(textBox1.Text, out x) && textBox2.Text == "")
            {
                MessageBox.Show("аргумент не число и не логическая переменная", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int a;
            double x;
            if (int.TryParse(textBox1.Text, out a) && textBox2.Text == "")
            {

                if (a > 1 || a < -1)
                {
                    MessageBox.Show("число не принадлежит отрезку 1,-1", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
                else
                listBox1.Items.Insert(0, "arcsin(" + a.ToString() + ")" + "=" + Math.Asin(a).ToString());             
            }
            else if (double.TryParse(textBox1.Text, out x) && textBox2.Text == "")
            {
                if (x > 1 || x < -1)
                {
                    MessageBox.Show("число не принадлежит отрезку 1,-1", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                listBox1.Items.Insert(0, "arcsin(" + x.ToString() + ")" + "=" + Math.Asin(x).ToString());
            }
            else if (double.TryParse(textBox1.Text, out x) && textBox2.Text != "")
            {
                MessageBox.Show("введите число только в первое окно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text != "")
            {
                MessageBox.Show("введите аргумент в первое поле", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("введите аргумент", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
            else if (!double.TryParse(textBox1.Text, out x) && textBox2.Text == "")
            {
                MessageBox.Show("аргумент не число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int a;
            double x;
            if (int.TryParse(textBox1.Text, out a) && textBox2.Text == "")
            {
                listBox1.Items.Insert(0, "arctan(" + a.ToString() + ")" + "=" + Math.Atan(a).ToString());
            }
            else if (double.TryParse(textBox1.Text, out x) && textBox2.Text == "")
            {
               
                listBox1.Items.Insert(0, "arcatan(" + x.ToString() + ")" + "=" + Math.Atan(x).ToString());
            }
            else if (double.TryParse(textBox1.Text, out x) && textBox2.Text != "")
            {
                MessageBox.Show("введите число только в первое окно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text != "")
            {
                MessageBox.Show("введите аргумент в первое поле", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("введите аргумент", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!double.TryParse(textBox1.Text, out x) && textBox2.Text == "")
            {
                MessageBox.Show("аргумент не число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b))
            {
                if (a % 2 == 0 && b < 0)
                {
                    MessageBox.Show("корень чётной степени из отрицательного числа не сущ-ет", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (a % 2 != 0 && b < 0)
                {
                    listBox1.Items.Insert(0, a.ToString() + "√" + b.ToString() + "=" + (-Math.Pow(-b, 1 / a)).ToString());
                }
                else
                    listBox1.Items.Insert(0, a.ToString() + "√" + b.ToString() + "=" + Math.Pow(b, 1 / a).ToString());
            }
            else if (!double.TryParse(textBox1.Text, out b) && double.TryParse(textBox2.Text, out a) && textBox1.Text != "")
            {
                MessageBox.Show("первый аргумент не число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!double.TryParse(textBox2.Text, out b) && double.TryParse(textBox1.Text, out a) && textBox2.Text != "")
            {
                MessageBox.Show("второй аргумент не число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text != "" && double.TryParse(textBox2.Text, out a))
            {
                MessageBox.Show("вы не ввели первое число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "" && textBox1.Text != "" && double.TryParse(textBox1.Text, out a))
            {
                MessageBox.Show("вы не ввели второе число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("вы не ввели оба числа", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("оба аргумента не явл числами", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double x, y, res;
            if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y))
            {
                if (y != 0)
                {
                    res = x % y;
                    listBox1.Items.Insert(0, x.ToString() + "%" + y.ToString() + "=" + res.ToString());
                }
                else
                {
                    MessageBox.Show("остаток от деления на 0 не сущестыует", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y) && textBox1.Text != "")
            {
                MessageBox.Show("первый аргумент не число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!double.TryParse(textBox2.Text, out y) && double.TryParse(textBox1.Text, out x) && textBox2.Text != "")
            {
                MessageBox.Show("второй аргумент не число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text != "" && double.TryParse(textBox2.Text, out x))
            {
                MessageBox.Show("вы не ввели первое число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "" && textBox1.Text != "" && double.TryParse(textBox1.Text, out x))
            {
                MessageBox.Show("вы не ввели второе число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("вы не ввели оба числа", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("оба аргумента не явл числами", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double a;
            if (double.TryParse(textBox1.Text, out a) && textBox2.Text == "")
            {
                if (Math.Truncate(Math.Log(a, 4)) == (Math.Log(a, 4)))
                {
                    listBox1.Items.Insert(0, "да");
                }
                else
                    listBox1.Items.Insert(0, "нет");
            }
            else if (!double.TryParse(textBox1.Text, out a) && textBox2.Text == "")
            {
                MessageBox.Show("аргумент не число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text != "")
            {
                MessageBox.Show("введите аргумент в первое поле", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.TryParse(textBox1.Text, out a) && textBox2.Text != "")
            {
                MessageBox.Show("введите число только в первое поле", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
    
