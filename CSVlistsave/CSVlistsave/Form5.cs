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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Shown(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("Product.txt");
            List<Class2> list = new List<Class2>();
            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split('|');
                list.Add(new Class2() { ProductName = data[0] , ProductPrice = data[1] });
            }
            dataGridView1.DataSource = list;
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            
        }

        
    }
}
