﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVlistsave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 f2= new Form2();
        Form3 f3= new Form3();
        Form4 f4 = new Form4();
        Form5 f5 = new Form5();

        private void button3_Click(object sender, EventArgs e)
        {
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f3.Show();
            f3.RefreshForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
               f5.Show();
            f5.RefreshForm();
        }
    }
}
