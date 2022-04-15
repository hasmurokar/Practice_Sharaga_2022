namespace _16_04_2022
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonShowList = new System.Windows.Forms.Button();
            this.buttonAddList = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelChange = new System.Windows.Forms.Label();
            this.buttonSecond = new System.Windows.Forms.Button();
            this.buttonMinute = new System.Windows.Forms.Button();
            this.buttonHour = new System.Windows.Forms.Button();
            this.changeTimeBox = new System.Windows.Forms.TextBox();
            this.labelSecond = new System.Windows.Forms.Label();
            this.labelMinute = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonTime = new System.Windows.Forms.Button();
            this.inputSecond = new System.Windows.Forms.TextBox();
            this.inputMinute = new System.Windows.Forms.TextBox();
            this.inputHour = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(577, 194);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 365);
            this.textBox1.TabIndex = 65;
            // 
            // buttonShowList
            // 
            this.buttonShowList.Location = new System.Drawing.Point(597, 52);
            this.buttonShowList.Name = "buttonShowList";
            this.buttonShowList.Size = new System.Drawing.Size(170, 81);
            this.buttonShowList.TabIndex = 64;
            this.buttonShowList.Text = "показать список";
            this.buttonShowList.UseVisualStyleBackColor = true;
            this.buttonShowList.Click += new System.EventHandler(this.buttonShowList_Click);
            // 
            // buttonAddList
            // 
            this.buttonAddList.Location = new System.Drawing.Point(263, 82);
            this.buttonAddList.Name = "buttonAddList";
            this.buttonAddList.Size = new System.Drawing.Size(170, 39);
            this.buttonAddList.TabIndex = 63;
            this.buttonAddList.Text = "добавить в список";
            this.buttonAddList.UseVisualStyleBackColor = true;
            this.buttonAddList.Click += new System.EventHandler(this.buttonAddList_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(39, 82);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(186, 39);
            this.buttonClear.TabIndex = 62;
            this.buttonClear.Text = "очистить список";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Location = new System.Drawing.Point(171, 367);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(325, 16);
            this.labelChange.TabIndex = 61;
            this.labelChange.Text = "Введите число и выберите, к чему его добавить:";
            // 
            // buttonSecond
            // 
            this.buttonSecond.Location = new System.Drawing.Point(359, 427);
            this.buttonSecond.Name = "buttonSecond";
            this.buttonSecond.Size = new System.Drawing.Size(75, 43);
            this.buttonSecond.TabIndex = 60;
            this.buttonSecond.Text = "секунды";
            this.buttonSecond.UseVisualStyleBackColor = true;
            this.buttonSecond.Click += new System.EventHandler(this.buttonSecond_Click);
            // 
            // buttonMinute
            // 
            this.buttonMinute.Location = new System.Drawing.Point(278, 427);
            this.buttonMinute.Name = "buttonMinute";
            this.buttonMinute.Size = new System.Drawing.Size(75, 43);
            this.buttonMinute.TabIndex = 59;
            this.buttonMinute.Text = "минуты";
            this.buttonMinute.UseVisualStyleBackColor = true;
            this.buttonMinute.Click += new System.EventHandler(this.buttonMinute_Click);
            // 
            // buttonHour
            // 
            this.buttonHour.Location = new System.Drawing.Point(197, 427);
            this.buttonHour.Name = "buttonHour";
            this.buttonHour.Size = new System.Drawing.Size(75, 43);
            this.buttonHour.TabIndex = 58;
            this.buttonHour.Text = "часы";
            this.buttonHour.UseVisualStyleBackColor = true;
            this.buttonHour.Click += new System.EventHandler(this.buttonHour_Click);
            // 
            // changeTimeBox
            // 
            this.changeTimeBox.Location = new System.Drawing.Point(196, 399);
            this.changeTimeBox.Name = "changeTimeBox";
            this.changeTimeBox.Size = new System.Drawing.Size(237, 22);
            this.changeTimeBox.TabIndex = 57;
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Location = new System.Drawing.Point(406, 247);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(67, 16);
            this.labelSecond.TabIndex = 56;
            this.labelSecond.Text = "Секунды:";
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Location = new System.Drawing.Point(292, 247);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(61, 16);
            this.labelMinute.TabIndex = 55;
            this.labelMinute.Text = "Минуты:";
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Location = new System.Drawing.Point(193, 247);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(43, 16);
            this.labelHour.TabIndex = 54;
            this.labelHour.Text = "Часы:";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(292, 197);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(57, 16);
            this.labelOutput.TabIndex = 53;
            this.labelOutput.Text = "**********";
            // 
            // buttonTime
            // 
            this.buttonTime.Location = new System.Drawing.Point(165, 294);
            this.buttonTime.Name = "buttonTime";
            this.buttonTime.Size = new System.Drawing.Size(312, 36);
            this.buttonTime.TabIndex = 52;
            this.buttonTime.Text = "добавить";
            this.buttonTime.UseVisualStyleBackColor = true;
            this.buttonTime.Click += new System.EventHandler(this.buttonTime_Click);
            // 
            // inputSecond
            // 
            this.inputSecond.Location = new System.Drawing.Point(377, 266);
            this.inputSecond.Name = "inputSecond";
            this.inputSecond.Size = new System.Drawing.Size(100, 22);
            this.inputSecond.TabIndex = 51;
            // 
            // inputMinute
            // 
            this.inputMinute.Location = new System.Drawing.Point(271, 266);
            this.inputMinute.Name = "inputMinute";
            this.inputMinute.Size = new System.Drawing.Size(100, 22);
            this.inputMinute.TabIndex = 50;
            // 
            // inputHour
            // 
            this.inputHour.Location = new System.Drawing.Point(165, 266);
            this.inputHour.Name = "inputHour";
            this.inputHour.Size = new System.Drawing.Size(100, 22);
            this.inputHour.TabIndex = 49;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(777, 30);
            this.menuStrip1.TabIndex = 66;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(58, 26);
            this.файлToolStripMenuItem.Text = "файл";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadToolStripMenuItem.Text = "загрузить";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(115, 504);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(36, 16);
            this.labelTimer.TabIndex = 67;
            this.labelTimer.Text = "timer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 568);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonShowList);
            this.Controls.Add(this.buttonAddList);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.buttonSecond);
            this.Controls.Add(this.buttonMinute);
            this.Controls.Add(this.buttonHour);
            this.Controls.Add(this.changeTimeBox);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.buttonTime);
            this.Controls.Add(this.inputSecond);
            this.Controls.Add(this.inputMinute);
            this.Controls.Add(this.inputHour);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Лаб. раб. №12 Згортюк";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonShowList;
        private System.Windows.Forms.Button buttonAddList;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.Button buttonSecond;
        private System.Windows.Forms.Button buttonMinute;
        private System.Windows.Forms.Button buttonHour;
        private System.Windows.Forms.TextBox changeTimeBox;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonTime;
        private System.Windows.Forms.TextBox inputSecond;
        private System.Windows.Forms.TextBox inputMinute;
        private System.Windows.Forms.TextBox inputHour;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTimer;
    }
}

