namespace _2_12_04_2022
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelFormule = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(569, 280);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(496, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart";
            // 
            // labelFormule
            // 
            this.labelFormule.AutoSize = true;
            this.labelFormule.Location = new System.Drawing.Point(464, 52);
            this.labelFormule.Name = "labelFormule";
            this.labelFormule.Size = new System.Drawing.Size(67, 16);
            this.labelFormule.TabIndex = 1;
            this.labelFormule.Text = "y = x^2 * A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите целое число от -10 до 10:";
            // 
            // textBox_A
            // 
            this.textBox_A.Location = new System.Drawing.Point(450, 135);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(100, 22);
            this.textBox_A.TabIndex = 3;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(450, 176);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(101, 23);
            this.button.TabIndex = 4;
            this.button.Text = "Рассчитать";
            this.button.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(849, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "x = 4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 592);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox_A);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFormule);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelFormule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label2;
    }
}

