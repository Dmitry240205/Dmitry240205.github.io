using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.X)
            {
                this.Close();
                return;
            }
            switch (e.KeyCode)
            {
                case Keys.Left:
                    this.Left -= 5;
                    break;
                case Keys.Right:
                    this.Left += 5;
                    break;
                case Keys.Up:
                    this.Top -= 5;
                    break;
                case Keys.Down:
                    this.Top += 5;
                    break;
                case Keys.Add:
                case Keys.Oemplus:
                    this.Width += 10;
                    this.Height += 10;
                    break;
                case Keys.Subtract:
                case Keys.OemMinus:
                    if (this.Width > 10 && this.Height > 10)
                    {
                        this.Width -= 10;
                        this.Height -= 10;
                    }
                    break;
            }
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
            return;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Поменять цвет?", "Форма запроса",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question)
           == DialogResult.Yes)
            {
                BackColor = Color.Green;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
                BackColor = Color.White;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Cursor = Cursors.Default;
                    break;
                case 1:
                    Cursor = Cursors.Hand;
                    break;
                case 2:
                    Cursor = Cursors.AppStarting;
                    break;
                case 3:
                    Cursor = Cursors.WaitCursor;
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            e.Cancel = checkBox1.Checked;
           
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            button1.Visible = !checkBox2.Checked;
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
                comboBox1.Enabled = !checkBox3.Checked;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    BackColor = Color.White;
                    break;
                case 1:
                    BackColor = Color.Red;
                    break;
                case 2:
                    BackColor = Color.Green;
                    break;
                case 3:
                    BackColor = Color.Blue;
                    break;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFormBorderStyle();
        }
        private void UpdateFormBorderStyle()
        {
            this.FormBorderStyle = checkBox4.Checked
                ? FormBorderStyle.Sizable
                : FormBorderStyle.None;
        }
    }
}




  