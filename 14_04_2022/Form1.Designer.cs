namespace _14_04_2022
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
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAddList = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonShowList = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Location = new System.Drawing.Point(106, 292);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(325, 16);
            this.labelChange.TabIndex = 25;
            this.labelChange.Text = "Введите число и выберите, к чему его добавить:";
            // 
            // buttonSecond
            // 
            this.buttonSecond.Location = new System.Drawing.Point(294, 352);
            this.buttonSecond.Name = "buttonSecond";
            this.buttonSecond.Size = new System.Drawing.Size(75, 43);
            this.buttonSecond.TabIndex = 24;
            this.buttonSecond.Text = "секунды";
            this.buttonSecond.UseVisualStyleBackColor = true;
            this.buttonSecond.Click += new System.EventHandler(this.buttonSecond_Click);
            // 
            // buttonMinute
            // 
            this.buttonMinute.Location = new System.Drawing.Point(213, 352);
            this.buttonMinute.Name = "buttonMinute";
            this.buttonMinute.Size = new System.Drawing.Size(75, 43);
            this.buttonMinute.TabIndex = 23;
            this.buttonMinute.Text = "минуты";
            this.buttonMinute.UseVisualStyleBackColor = true;
            this.buttonMinute.Click += new System.EventHandler(this.buttonMinute_Click);
            // 
            // buttonHour
            // 
            this.buttonHour.Location = new System.Drawing.Point(132, 352);
            this.buttonHour.Name = "buttonHour";
            this.buttonHour.Size = new System.Drawing.Size(75, 43);
            this.buttonHour.TabIndex = 22;
            this.buttonHour.Text = "часы";
            this.buttonHour.UseVisualStyleBackColor = true;
            this.buttonHour.Click += new System.EventHandler(this.buttonHour_Click);
            // 
            // changeTimeBox
            // 
            this.changeTimeBox.Location = new System.Drawing.Point(131, 324);
            this.changeTimeBox.Name = "changeTimeBox";
            this.changeTimeBox.Size = new System.Drawing.Size(237, 22);
            this.changeTimeBox.TabIndex = 21;
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Location = new System.Drawing.Point(341, 172);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(67, 16);
            this.labelSecond.TabIndex = 20;
            this.labelSecond.Text = "Секунды:";
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Location = new System.Drawing.Point(227, 172);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(61, 16);
            this.labelMinute.TabIndex = 19;
            this.labelMinute.Text = "Минуты:";
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Location = new System.Drawing.Point(128, 172);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(43, 16);
            this.labelHour.TabIndex = 18;
            this.labelHour.Text = "Часы:";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(227, 96);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(57, 16);
            this.labelOutput.TabIndex = 17;
            this.labelOutput.Text = "**********";
            // 
            // buttonTime
            // 
            this.buttonTime.Location = new System.Drawing.Point(100, 219);
            this.buttonTime.Name = "buttonTime";
            this.buttonTime.Size = new System.Drawing.Size(312, 36);
            this.buttonTime.TabIndex = 16;
            this.buttonTime.Text = "добавить";
            this.buttonTime.UseVisualStyleBackColor = true;
            this.buttonTime.Click += new System.EventHandler(this.buttonTime_Click);
            // 
            // inputSecond
            // 
            this.inputSecond.Location = new System.Drawing.Point(312, 191);
            this.inputSecond.Name = "inputSecond";
            this.inputSecond.Size = new System.Drawing.Size(100, 22);
            this.inputSecond.TabIndex = 15;
            // 
            // inputMinute
            // 
            this.inputMinute.Location = new System.Drawing.Point(206, 191);
            this.inputMinute.Name = "inputMinute";
            this.inputMinute.Size = new System.Drawing.Size(100, 22);
            this.inputMinute.TabIndex = 14;
            // 
            // inputHour
            // 
            this.inputHour.Location = new System.Drawing.Point(100, 191);
            this.inputHour.Name = "inputHour";
            this.inputHour.Size = new System.Drawing.Size(100, 22);
            this.inputHour.TabIndex = 13;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(456, 54);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(186, 39);
            this.buttonClear.TabIndex = 26;
            this.buttonClear.Text = "очистить список";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAddList
            // 
            this.buttonAddList.Location = new System.Drawing.Point(648, 54);
            this.buttonAddList.Name = "buttonAddList";
            this.buttonAddList.Size = new System.Drawing.Size(170, 39);
            this.buttonAddList.TabIndex = 27;
            this.buttonAddList.Text = "добавить в список";
            this.buttonAddList.UseVisualStyleBackColor = true;
            this.buttonAddList.Click += new System.EventHandler(this.buttonAddList_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 28);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.файлToolStripMenuItem.Text = "файл";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "сохранить...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "открыть...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // buttonShowList
            // 
            this.buttonShowList.Location = new System.Drawing.Point(648, 107);
            this.buttonShowList.Name = "buttonShowList";
            this.buttonShowList.Size = new System.Drawing.Size(170, 81);
            this.buttonShowList.TabIndex = 30;
            this.buttonShowList.Text = "показать список";
            this.buttonShowList.UseVisualStyleBackColor = true;
            this.buttonShowList.Click += new System.EventHandler(this.buttonShowList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 536);
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
            this.Text = "Лаб. раб. №10 Згортюк";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAddList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button buttonShowList;
    }
}

