﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 temp = new Form2();
            temp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 temp = new Form3();
            temp.Show(this);
        }
    }
}
