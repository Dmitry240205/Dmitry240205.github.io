using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1: Form
    {
        int Oper = 0;
        Double Value = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "0";
            else textBox1.Text = textBox1.Text + "0";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "1";
            else textBox1.Text = textBox1.Text + "1";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "2";
            else textBox1.Text = textBox1.Text + "2";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "3";
            else textBox1.Text = textBox1.Text + "3";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "4";
            else textBox1.Text = textBox1.Text + "4";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "5";
            else textBox1.Text = textBox1.Text + "5";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "6";
            else textBox1.Text = textBox1.Text + "6";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "7";
            else textBox1.Text = textBox1.Text + "7";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "8";
            else textBox1.Text = textBox1.Text + "8";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "9";
            else textBox1.Text = textBox1.Text + "9";
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.LastIndexOf(',') < 0)
                textBox1.Text = textBox1.Text + ",";
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[0] == '-') textBox1.Text = textBox1.Text.Remove(0, 1);
            else textBox1.Text = "-" + textBox1.Text;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                Control activeControl = this.ActiveControl;
                if (activeControl != null && activeControl is TextBoxBase)
                {
                    TextBoxBase textControl = (TextBoxBase)activeControl;
                    if (textControl.Text.Length > 0)
                    {
                        textControl.Text = textControl.Text.Remove(textControl.Text.Length - 1);
                        textControl.SelectionStart = textControl.Text.Length;
                    }
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double Value2 = Convert.ToDouble(textBox1.Text);
            Double Result = Value2;
            switch (Oper)
            {
                case 1:
                    Result = Value + Value2;
                    break;
                case 2:
                    Result = Value - Value2;
                    break;
                case 3:
                    Result = Value * Value2;
                    break;
                case 4:
                    Result = Value / Value2;
                    break;
            }
            textBox1.Text = Result.ToString();
            Value = 0;
            Oper = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            Value = Convert.ToDouble(textBox1.Text);
            Oper = 1;
            textBox1.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            Value = Convert.ToDouble(textBox1.Text);
            Oper = 4;
            textBox1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            Value = Convert.ToDouble(textBox1.Text);
            Oper = 3;
            textBox1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            Value = Convert.ToDouble(textBox1.Text);
            Oper = 2;
            textBox1.Text = "0";
        }
    }
}

