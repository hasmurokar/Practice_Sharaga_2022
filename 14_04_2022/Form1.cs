using Newtonsoft.Json;
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

namespace _14_04_2022
{
    public partial class Form1 : Form
    {
        List<Time> timeList = new List<Time>();
        Time time = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTime_Click(object sender, EventArgs e)
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

        private void buttonMinute_Click(object sender, EventArgs e)
        {
            time.EditMinute(Convert.ToInt32(changeTimeBox.Text));
            labelOutput.Text = time.Output();
        }

        private void buttonSecond_Click(object sender, EventArgs e)
        {
            time.EditSecond(Convert.ToInt32(changeTimeBox.Text));
            labelOutput.Text = time.Output();
        }

        private void buttonAddList_Click(object sender, EventArgs e)
        {
            timeList.Add(new Time(Convert.ToInt32(inputHour.Text), Convert.ToInt32(inputMinute.Text), Convert.ToInt32(inputSecond.Text)));
            labelOutput.Text = "*********";
            inputHour.Clear();
            inputMinute.Clear();
            inputSecond.Clear();
        }

        private void buttonShowList_Click(object sender, EventArgs e)
        {
            string ms = "";
            foreach (var item in timeList)
            {
                var message = string.Join(Environment.NewLine, item.Output());
                ms += message + "\n";
            }
            MessageBox.Show(ms);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            timeList.Clear();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Task_14_04.json", JsonConvert.SerializeObject(timeList));
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timeList = JsonConvert.DeserializeObject<List<Time>>(File.ReadAllText("Task_14_04.json"));
        }
    }
}
