namespace _13_04_2022_
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
            this.inputHour = new System.Windows.Forms.TextBox();
            this.inputMinute = new System.Windows.Forms.TextBox();
            this.inputSecond = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelMinute = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.changeTimeBox = new System.Windows.Forms.TextBox();
            this.buttonHour = new System.Windows.Forms.Button();
            this.buttonSecond = new System.Windows.Forms.Button();
            this.buttonMinute = new System.Windows.Forms.Button();
            this.labelChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputHour
            // 
            this.inputHour.Location = new System.Drawing.Point(315, 233);
            this.inputHour.Name = "inputHour";
            this.inputHour.Size = new System.Drawing.Size(100, 22);
            this.inputHour.TabIndex = 0;
            // 
            // inputMinute
            // 
            this.inputMinute.Location = new System.Drawing.Point(421, 233);
            this.inputMinute.Name = "inputMinute";
            this.inputMinute.Size = new System.Drawing.Size(100, 22);
            this.inputMinute.TabIndex = 1;
            // 
            // inputSecond
            // 
            this.inputSecond.Location = new System.Drawing.Point(527, 233);
            this.inputSecond.Name = "inputSecond";
            this.inputSecond.Size = new System.Drawing.Size(100, 22);
            this.inputSecond.TabIndex = 2;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(315, 261);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(312, 36);
            this.button.TabIndex = 3;
            this.button.Text = "добавить";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(446, 141);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(57, 16);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.Text = "**********";
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Location = new System.Drawing.Point(343, 214);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(43, 16);
            this.labelHour.TabIndex = 5;
            this.labelHour.Text = "Часы:";
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Location = new System.Drawing.Point(442, 214);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(61, 16);
            this.labelMinute.TabIndex = 6;
            this.labelMinute.Text = "Минуты:";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Location = new System.Drawing.Point(556, 214);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(67, 16);
            this.labelSecond.TabIndex = 7;
            this.labelSecond.Text = "Секунды:";
            // 
            // changeTimeBox
            // 
            this.changeTimeBox.Location = new System.Drawing.Point(701, 394);
            this.changeTimeBox.Name = "changeTimeBox";
            this.changeTimeBox.Size = new System.Drawing.Size(237, 22);
            this.changeTimeBox.TabIndex = 8;
            // 
            // buttonHour
            // 
            this.buttonHour.Location = new System.Drawing.Point(701, 437);
            this.buttonHour.Name = "buttonHour";
            this.buttonHour.Size = new System.Drawing.Size(75, 43);
            this.buttonHour.TabIndex = 9;
            this.buttonHour.Text = "часы";
            this.buttonHour.UseVisualStyleBackColor = true;
            this.buttonHour.Click += new System.EventHandler(this.buttonHour_Click);
            // 
            // buttonSecond
            // 
            this.buttonSecond.Location = new System.Drawing.Point(782, 437);
            this.buttonSecond.Name = "buttonSecond";
            this.buttonSecond.Size = new System.Drawing.Size(75, 43);
            this.buttonSecond.TabIndex = 10;
            this.buttonSecond.Text = "минуты";
            this.buttonSecond.UseVisualStyleBackColor = true;
            this.buttonSecond.Click += new System.EventHandler(this.buttonSecond_Click);
            // 
            // buttonMinute
            // 
            this.buttonMinute.Location = new System.Drawing.Point(863, 437);
            this.buttonMinute.Name = "buttonMinute";
            this.buttonMinute.Size = new System.Drawing.Size(75, 43);
            this.buttonMinute.TabIndex = 11;
            this.buttonMinute.Text = "секунды";
            this.buttonMinute.UseVisualStyleBackColor = true;
            this.buttonMinute.Click += new System.EventHandler(this.buttonMinute_Click);
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Location = new System.Drawing.Point(664, 364);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(325, 16);
            this.labelChange.TabIndex = 12;
            this.labelChange.Text = "Введите число и выберите, к чему его добавить:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 602);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.buttonMinute);
            this.Controls.Add(this.buttonSecond);
            this.Controls.Add(this.buttonHour);
            this.Controls.Add(this.changeTimeBox);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.button);
            this.Controls.Add(this.inputSecond);
            this.Controls.Add(this.inputMinute);
            this.Controls.Add(this.inputHour);
            this.Name = "Form1";
            this.Text = "Лаб. раб. №9 Згортюк";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputHour;
        private System.Windows.Forms.TextBox inputMinute;
        private System.Windows.Forms.TextBox inputSecond;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.TextBox changeTimeBox;
        private System.Windows.Forms.Button buttonHour;
        private System.Windows.Forms.Button buttonSecond;
        private System.Windows.Forms.Button buttonMinute;
        private System.Windows.Forms.Label labelChange;
    }
}

