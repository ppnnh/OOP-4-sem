using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePickerOprningDate.MaxDate = DateTime.Now;
            Control.Loading();
            Control.GlobalInfoChange(labelGlobalInfo);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Bill bill;
            bool? sms;
            ConcreteBuilder builder = new ConcreteBuilder();

            if (radioButtonYes.Checked == radioButtonNo.Checked)
            {
                sms = null;
            }
            else
            {
                sms = radioButtonYes.Checked;
            }
            
            switch (comboBoxBillType.Text)
            {
                case "детский":
                    bill = Control.Factory(new ChildFactory());
                    break;

                case "стандартный":
                    bill = Control.Factory(new StandardFactory());
                    break;

                case "валютный":
                    bill = Control.Factory(new CurrencyFactory());
                    break;

                default:
                    MessageBox.Show("Выберите тип вклада", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            builder.BuildPartA(textBoxNumber.Text, Control.Owner);
            builder.BuildPartB(dateTimePickerOprningDate.Value.Date, numericUpDownBalance.Value);
            builder.BuildPartC(checkBoxYes.Checked, sms);

            bill = builder.Getbill();

            if (Control.Validate(bill))
            {
                Bill bill1 = (Bill)bill.Clone();
                Control.AddBill(bill1);
                Control.SaveToFile();
                MessageBox.Show("Счёт добавлен");
                FieldsCleaning();
                Control.GlobalInfoChange(labelGlobalInfo);

              
            }
        }

        private void button_MouseHover(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.Purple;
            button.ForeColor = Color.Black;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.Black;
            button.ForeColor = Color.Purple;
        }

        private void buttonCreateOwner_Click(object sender, EventArgs e)
        {
            CreatingOwner creatingOwner = new CreatingOwner();
            creatingOwner.ShowDialog();
        }

        private void FieldsCleaning()
        {
            textBoxNumber.Clear();
            comboBoxBillType.SelectedIndex = -1;
            numericUpDownBalance.Value = 1000;
            dateTimePickerOprningDate.Value = dateTimePickerOprningDate.MaxDate;
            radioButtonYes.Checked = false;
            radioButtonNo.Checked = false;
            checkBoxYes.Checked = false;
        }

        private void buttonReadFromFile_Click(object sender, EventArgs e)
        {
            Info creatingOwner = new Info();
            creatingOwner.ShowDialog();
            Control.GlobalInfoChange(labelGlobalInfo);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.1\nBuranko V D", "О программе");
        }

        private void buttonForSingleton_Click(object sender, EventArgs e)
        {
            Singleton singleton;
            singleton = Singleton.GetInstance($"1{buttonForSingleton.BackColor = Color.Beige}");
            Singleton singleton2;
            singleton2 = Singleton.GetInstance($"2");
            //singleton.Settings = $"3{buttonForSingleton.BackColor=Color.Red}";

            Button button = sender as Button;
            button.Text = singleton2.Settings;
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownBalance_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxBillType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}