using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVlistsave
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("customer.txt");
            List<Class1> list = new List<Class1>();
            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split('|');
                list.Add(new Class1() { customerName = data[0], customerLastname = data[1], customerAddress = data[2], customerEmail = data[3], customerPhone = data[4] });
            }
            dataGridView1.DataSource = list;
            

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
           e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
