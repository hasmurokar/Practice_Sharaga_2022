using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_04_2022_
{
    public partial class Form1 : Form
    {
        Time time = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputHour.Text) || string.IsNullOrWhiteSpace(inputMinute.Text) || string.IsNullOrWhiteSpace(inputSecond.Text))
            {
                MessageBox.Show("Некорректно введено время");
                return;
            }
            var hour = int.Parse(inputHour.Text);
            var minute = int.Parse(inputMinute.Text);
            var second = int.Parse(inputSecond.Text);
            time = Time.InputTime(hour, minute, second);
            labelOutput.Text = time.Output();
        }

        private void buttonHour_Click(object sender, EventArgs e)
        {
            time.EditHour(Convert.ToInt32(changeTimeBox.Text));
            labelOutput.Text = time.Output();
        }

        private void buttonSecond_Click(object sender, EventArgs e)
        {
            time.EditMinute(Convert.ToInt32(changeTimeBox.Text));
            labelOutput.Text = time.Output();
        }

        private void buttonMinute_Click(object sender, EventArgs e)
        {
            time.EditSecond(Convert.ToInt32(changeTimeBox.Text));
            labelOutput.Text = time.Output();
        }
    }
}
