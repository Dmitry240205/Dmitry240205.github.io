using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         //Form1 progressBar1Value = Convert.ToInt32(value: Form3.Text);
        }

        private void Form3_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
