using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_04_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            textBox1.Text = "*****";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "********";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            textBox1.Text = "+++++++";
        }
    }
}
