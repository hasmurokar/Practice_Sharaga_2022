using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _2_12_04_2022
{
    public partial class Form1 : Form
    {
        private static int A { get; set; }
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart.ChartAreas.Add(new ChartArea("График"));
        }
        private void InitChart(out Series series)
        {
            chart.Series.Clear();
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            series = new Series(Convert.ToString(rnd.Next(0, 1000)));
            series.ChartType = SeriesChartType.Line;
            series.ChartArea = "График";
        }
        private void BuildGraphic(Series series)
        {
            var start = 0;
            var end = 4;
            for (double i = start; i <= end; i ++)
            {
                series.Points.AddXY(i, GetY(i));
            }
            chart.Series.Add(series);
        }
        private double GetY(double x)
        {
            return Math.Pow(x, 2) * A;
        }

        private void button_Click(object sender, EventArgs e)
        {
            A = Convert.ToInt32(textBox_A.Text);
            if (A < -10 || A > 10)
            {
                labelOutput.Text = "Число вне диапазона";
                return;
            }
            InitChart(out Series series);
            BuildGraphic(series);
        }
    }
}
