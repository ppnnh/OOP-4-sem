namespace Laba_2
{
    partial class Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.номерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фИОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.балансToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типВкладаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типВкладаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.датаОткрытияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вывестиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpeningDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Birthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Passport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SMSAlert = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InternetAlert = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewInfo = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.сортировкаToolStripMenuItem,
            this.выборкаToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(799, 26);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.номерToolStripMenuItem,
            this.фИОToolStripMenuItem,
            this.балансToolStripMenuItem,
            this.типВкладаToolStripMenuItem});
            this.поискToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.поискToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(70, 22);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // номерToolStripMenuItem
            // 
            this.номерToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.номерToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.номерToolStripMenuItem.Name = "номерToolStripMenuItem";
            this.номерToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.номерToolStripMenuItem.Tag = "0";
            this.номерToolStripMenuItem.Text = "Номер";
            this.номерToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // фИОToolStripMenuItem
            // 
            this.фИОToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.фИОToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.фИОToolStripMenuItem.Name = "фИОToolStripMenuItem";
            this.фИОToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.фИОToolStripMenuItem.Tag = "1";
            this.фИОToolStripMenuItem.Text = "ФИО";
            this.фИОToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // балансToolStripMenuItem
            // 
            this.балансToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.балансToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.балансToolStripMenuItem.Name = "балансToolStripMenuItem";
            this.балансToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.балансToolStripMenuItem.Tag = "2";
            this.балансToolStripMenuItem.Text = "Баланс";
            this.балансToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // типВкладаToolStripMenuItem
            // 
            this.типВкладаToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.типВкладаToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.типВкладаToolStripMenuItem.Name = "типВкладаToolStripMenuItem";
            this.типВкладаToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.типВкладаToolStripMenuItem.Tag = "3";
            this.типВкладаToolStripMenuItem.Text = "Тип Вклада";
            this.типВкладаToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типВкладаToolStripMenuItem1,
            this.датаОткрытияToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сортировкаToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // типВкладаToolStripMenuItem1
            // 
            this.типВкладаToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Window;
            this.типВкладаToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.типВкладаToolStripMenuItem1.Name = "типВкладаToolStripMenuItem1";
            this.типВкладаToolStripMenuItem1.Size = new System.Drawing.Size(212, 24);
            this.типВкладаToolStripMenuItem1.Tag = "0";
            this.типВкладаToolStripMenuItem1.Text = "Тип вклада";
            this.типВкладаToolStripMenuItem1.Click += new System.EventHandler(this.сортировкаToolStripMenuItem_Click);
            // 
            // датаОткрытияToolStripMenuItem
            // 
            this.датаОткрытияToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.датаОткрытияToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.датаОткрытияToolStripMenuItem.Name = "датаОткрытияToolStripMenuItem";
            this.датаОткрытияToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.датаОткрытияToolStripMenuItem.Tag = "1";
            this.датаОткрытияToolStripMenuItem.Text = "Дата открытия";
            this.датаОткрытияToolStripMenuItem.Click += new System.EventHandler(this.сортировкаToolStripMenuItem_Click);
            // 
            // выборкаToolStripMenuItem
            // 
            this.выборкаToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.выборкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.вывестиToolStripMenuItem});
            this.выборкаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выборкаToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.выборкаToolStripMenuItem.Name = "выборкаToolStripMenuItem";
            this.выборкаToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.выборкаToolStripMenuItem.Text = "Выборка";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // вывестиToolStripMenuItem
            // 
            this.вывестиToolStripMenuItem.Name = "вывестиToolStripMenuItem";
            this.вывестиToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.вывестиToolStripMenuItem.Text = "Посмотреть";
            this.вывестиToolStripMenuItem.Click += new System.EventHandler(this.вывестиToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.удалитьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.удалитьToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // Number
            // 
            this.Number.Text = "Номер";
            this.Number.Width = 80;
            // 
            // Balance
            // 
            this.Balance.Text = "Баланс";
            this.Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Balance.Width = 91;
            // 
            // OpeningDate
            // 
            this.OpeningDate.Text = "Дата открытия";
            this.OpeningDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OpeningDate.Width = 112;
            // 
            // FullName
            // 
            this.FullName.Text = "ФИО";
            this.FullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FullName.Width = 99;
            // 
            // Birthday
            // 
            this.Birthday.Text = "Дата рождения";
            this.Birthday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Birthday.Width = 120;
            // 
            // Passport
            // 
            this.Passport.Text = "Паспорт";
            this.Passport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Passport.Width = 95;
            // 
            // SMSAlert
            // 
            this.SMSAlert.Text = "SMS";
            this.SMSAlert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SMSAlert.Width = 68;
            // 
            // InternetAlert
            // 
            this.InternetAlert.Text = "Banking";
            this.InternetAlert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InternetAlert.Width = 78;
            // 
            // listViewInfo
            // 
            this.listViewInfo.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewInfo.BackColor = System.Drawing.SystemColors.InfoText;
            this.listViewInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewInfo.CheckBoxes = true;
            this.listViewInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.Balance,
            this.OpeningDate,
            this.FullName,
            this.Birthday,
            this.Passport,
            this.SMSAlert,
            this.InternetAlert});
            this.listViewInfo.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.listViewInfo.ForeColor = System.Drawing.Color.DarkViolet;
            this.listViewInfo.HideSelection = false;
            this.listViewInfo.HoverSelection = true;
            this.listViewInfo.Location = new System.Drawing.Point(0, 28);
            this.listViewInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewInfo.Name = "listViewInfo";
            this.listViewInfo.Size = new System.Drawing.Size(799, 305);
            this.listViewInfo.TabIndex = 23;
            this.listViewInfo.UseCompatibleStateImageBehavior = false;
            this.listViewInfo.View = System.Windows.Forms.View.Details;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(799, 332);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listViewInfo);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информационная панель";
            this.Load += new System.EventHandler(this.Info_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem номерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фИОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem балансToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типВкладаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типВкладаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem датаОткрытияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вывестиToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Balance;
        private System.Windows.Forms.ColumnHeader OpeningDate;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.ColumnHeader Birthday;
        private System.Windows.Forms.ColumnHeader Passport;
        private System.Windows.Forms.ColumnHeader SMSAlert;
        private System.Windows.Forms.ColumnHeader InternetAlert;
        private System.Windows.Forms.ListView listViewInfo;
    }
}