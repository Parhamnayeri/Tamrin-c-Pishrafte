using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace CSVlistsave
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string i = "|";
            string name = textBox1.Text;
            string lastname = textBox2.Text;
            string address = textBox3.Text;
            string number = textBox4.Text;
            string email = textBox5.Text;
            string line = name + i + lastname + i + address + i + number + i + email + "\n";
            File.AppendAllText("customer.txt", line);
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
