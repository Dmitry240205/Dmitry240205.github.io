using System;
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
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Width = Convert.ToInt32(textBox1.Text);
            Height = Convert.ToInt32(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Width = Convert.ToInt32(textBox1.Text);
            Owner.Height = Convert.ToInt32(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
