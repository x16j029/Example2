﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example2
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = String.Format("{0}", 1 + 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = String.Format("{0}", 5-3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label7.Text = String.Format("{0}", 2 * 3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label8.Text = String.Format("{0}", 8 / 2);
        }
    }
}
