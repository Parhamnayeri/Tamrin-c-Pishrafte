using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibo_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string num = textBox1.Text;
                int n = int.Parse(num);
                int x;
                n = n - 1;
                if (n < 1)
                {
                    MessageBox.Show("adde manfi va sefr nanevis");
                    return;
                }
                x = fib(n);
                MessageBox.Show("ozve "+(n+1)+" hast :"+x.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private static int fib(int n)
        {
            if (n <= 0)
                return n;
            if (n == 1)
                return n;
            else
                return fib(n - 1) + fib(n - 2);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
