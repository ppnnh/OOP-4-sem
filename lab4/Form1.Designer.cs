namespace Laba_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBillType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownBalance = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerOprningDate = new System.Windows.Forms.DateTimePicker();
            this.buttonCreateOwner = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxYes = new System.Windows.Forms.CheckBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonReadFromFile = new System.Windows.Forms.Button();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.labelGlobalInfo = new System.Windows.Forms.Label();
            this.buttonForSingleton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBalance)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxNumber.Font = new System.Drawing.Font("Courier New", 12F);
            this.textBoxNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxNumber.Location = new System.Drawing.Point(200, 43);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(149, 28);
            this.textBoxNumber.TabIndex = 3;
            this.textBoxNumber.TextChanged += new System.EventHandler(this.textBoxNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(9, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Тип вклада:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxBillType
            // 
            this.comboBoxBillType.BackColor = System.Drawing.SystemColors.InfoText;
            this.comboBoxBillType.Font = new System.Drawing.Font("Courier New", 12F);
            this.comboBoxBillType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.comboBoxBillType.FormattingEnabled = true;
            this.comboBoxBillType.Items.AddRange(new object[] {
            "детский",
            "стандартный",
            "валютный"});
            this.comboBoxBillType.Location = new System.Drawing.Point(200, 97);
            this.comboBoxBillType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxBillType.Name = "comboBoxBillType";
            this.comboBoxBillType.Size = new System.Drawing.Size(149, 28);
            this.comboBoxBillType.TabIndex = 5;
            this.comboBoxBillType.SelectedIndexChanged += new System.EventHandler(this.comboBoxBillType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(9, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Баланс:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numericUpDownBalance
            // 
            this.numericUpDownBalance.BackColor = System.Drawing.SystemColors.InfoText;
            this.numericUpDownBalance.Font = new System.Drawing.Font("Courier New", 12F);
            this.numericUpDownBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.numericUpDownBalance.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownBalance.Location = new System.Drawing.Point(200, 157);
            this.numericUpDownBalance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownBalance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownBalance.Name = "numericUpDownBalance";
            this.numericUpDownBalance.Size = new System.Drawing.Size(82, 28);
            this.numericUpDownBalance.TabIndex = 7;
            this.numericUpDownBalance.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownBalance.ValueChanged += new System.EventHandler(this.numericUpDownBalance_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(9, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата открытия:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateTimePickerOprningDate
            // 
            this.dateTimePickerOprningDate.CalendarMonthBackground = System.Drawing.SystemColors.InfoText;
            this.dateTimePickerOprningDate.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePickerOprningDate.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerOprningDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerOprningDate.Location = new System.Drawing.Point(200, 211);
            this.dateTimePickerOprningDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerOprningDate.Name = "dateTimePickerOprningDate";
            this.dateTimePickerOprningDate.Size = new System.Drawing.Size(184, 32);
            this.dateTimePickerOprningDate.TabIndex = 9;
            // 
            // buttonCreateOwner
            // 
            this.buttonCreateOwner.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonCreateOwner.Font = new System.Drawing.Font("Courier New", 12F);
            this.buttonCreateOwner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonCreateOwner.Location = new System.Drawing.Point(9, 268);
            this.buttonCreateOwner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreateOwner.Name = "buttonCreateOwner";
            this.buttonCreateOwner.Size = new System.Drawing.Size(373, 39);
            this.buttonCreateOwner.TabIndex = 10;
            this.buttonCreateOwner.Text = "Информация о владельце";
            this.buttonCreateOwner.UseVisualStyleBackColor = false;
            this.buttonCreateOwner.Click += new System.EventHandler(this.buttonCreateOwner_Click);
            this.buttonCreateOwner.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonCreateOwner.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(9, 332);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 40);
            this.label5.TabIndex = 11;
            this.label5.Text = "Подключение \r\nсмс оповещения:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.BackColor = System.Drawing.SystemColors.MenuText;
            this.radioButtonNo.Font = new System.Drawing.Font("Courier New", 12F);
            this.radioButtonNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radioButtonNo.Location = new System.Drawing.Point(200, 354);
            this.radioButtonNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(60, 24);
            this.radioButtonNo.TabIndex = 13;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "Нет";
            this.radioButtonNo.UseVisualStyleBackColor = false;
            this.radioButtonNo.CheckedChanged += new System.EventHandler(this.radioButtonNo_CheckedChanged);
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.BackColor = System.Drawing.SystemColors.MenuText;
            this.radioButtonYes.Font = new System.Drawing.Font("Courier New", 12F);
            this.radioButtonYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radioButtonYes.Location = new System.Drawing.Point(200, 330);
            this.radioButtonYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(49, 24);
            this.radioButtonYes.TabIndex = 14;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Да";
            this.radioButtonYes.UseVisualStyleBackColor = false;
            this.radioButtonYes.CheckedChanged += new System.EventHandler(this.radioButtonYes_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(9, 400);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 40);
            this.label6.TabIndex = 15;
            this.label6.Text = "Подключение\r\nинтернет-банкинга: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // checkBoxYes
            // 
            this.checkBoxYes.AutoSize = true;
            this.checkBoxYes.Font = new System.Drawing.Font("Courier New", 12F);
            this.checkBoxYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.checkBoxYes.Location = new System.Drawing.Point(200, 422);
            this.checkBoxYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxYes.Name = "checkBoxYes";
            this.checkBoxYes.Size = new System.Drawing.Size(50, 24);
            this.checkBoxYes.TabIndex = 16;
            this.checkBoxYes.Text = "Да";
            this.checkBoxYes.UseVisualStyleBackColor = true;
            this.checkBoxYes.CheckedChanged += new System.EventHandler(this.checkBoxYes_CheckedChanged);
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonCreate.Font = new System.Drawing.Font("Courier New", 12F);
            this.buttonCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonCreate.Location = new System.Drawing.Point(9, 471);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(184, 39);
            this.buttonCreate.TabIndex = 17;
            this.buttonCreate.Text = "Добавить";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            this.buttonCreate.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonCreate.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // buttonReadFromFile
            // 
            this.buttonReadFromFile.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonReadFromFile.Font = new System.Drawing.Font("Courier New", 12F);
            this.buttonReadFromFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonReadFromFile.Location = new System.Drawing.Point(200, 471);
            this.buttonReadFromFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReadFromFile.Name = "buttonReadFromFile";
            this.buttonReadFromFile.Size = new System.Drawing.Size(184, 39);
            this.buttonReadFromFile.TabIndex = 20;
            this.buttonReadFromFile.Text = "Просмотр";
            this.buttonReadFromFile.UseVisualStyleBackColor = false;
            this.buttonReadFromFile.Click += new System.EventHandler(this.buttonReadFromFile_Click);
            this.buttonReadFromFile.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonReadFromFile.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.оПрограммеToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlText;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(393, 26);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStripMain";
            // 
            // labelGlobalInfo
            // 
            this.labelGlobalInfo.Font = new System.Drawing.Font("Courier New", 10.8F);
            this.labelGlobalInfo.ForeColor = System.Drawing.Color.Purple;
            this.labelGlobalInfo.Location = new System.Drawing.Point(276, 332);
            this.labelGlobalInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGlobalInfo.Name = "labelGlobalInfo";
            this.labelGlobalInfo.Size = new System.Drawing.Size(106, 121);
            this.labelGlobalInfo.TabIndex = 22;
            // 
            // buttonForSingleton
            // 
            this.buttonForSingleton.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonForSingleton.Font = new System.Drawing.Font("Courier New", 12F);
            this.buttonForSingleton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonForSingleton.Location = new System.Drawing.Point(138, 37);
            this.buttonForSingleton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonForSingleton.Name = "buttonForSingleton";
            this.buttonForSingleton.Size = new System.Drawing.Size(37, 39);
            this.buttonForSingleton.TabIndex = 23;
            this.buttonForSingleton.UseVisualStyleBackColor = false;
            this.buttonForSingleton.Click += new System.EventHandler(this.buttonForSingleton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(393, 520);
            this.Controls.Add(this.buttonForSingleton);
            this.Controls.Add(this.labelGlobalInfo);
            this.Controls.Add(this.buttonReadFromFile);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.checkBoxYes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButtonYes);
            this.Controls.Add(this.radioButtonNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCreateOwner);
            this.Controls.Add(this.dateTimePickerOprningDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxBillType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Полубанк";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBalance)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBillType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerOprningDate;
        private System.Windows.Forms.Button buttonCreateOwner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxYes;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonReadFromFile;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label labelGlobalInfo;
        private System.Windows.Forms.Button buttonForSingleton;
    }
}

