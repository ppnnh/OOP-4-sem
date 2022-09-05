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
            Control.Loading(textBoxNumber);
            labelGlobalInfo.Text = Control.GlobalInfoChange();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Bill bill;
            bool? sms;
            Director director = new Director();
            ConcreteBuilder builder = new ConcreteBuilder();
            director.Builder = builder;

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

            /*builder.BuildPartA(textBoxNumber.Text, Control.Owner);
            builder.BuildPartB(dateTimePickerOprningDate.Value.Date, numericUpDownBalance.Value);
            builder.BuildPartC(checkBoxYes.Checked, sms);*/

            director.BuildFullFeaturedBill(textBoxNumber.Text, numericUpDownBalance.Value,
                dateTimePickerOprningDate.Value.Date, Control.Owner, checkBoxYes.Checked, sms);

            bill = builder.Getbill();

            if (Control.Validate(bill))
            {
                Control.AddBill(bill);
                Bill bill1 = (Bill)bill.Clone();
                Adapter adapter = new Adapter(bill1);
                bill1 = (Bill)adapter.Clone();
                Control.SaveToFile();
                MessageBox.Show("Счёт добавлен");
                FieldsCleaning();
                labelGlobalInfo.Text = Control.GlobalInfoChange();
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
            labelGlobalInfo.Text = Control.GlobalInfoChange();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 0.0001\nBuranko V D", "О программе");
        }

        private void buttonForSingleton_Click(object sender, EventArgs e)
        {
            Control.ChangeText(textBoxNumber.Text);
        }

        private void BackUp_Click(object sender, EventArgs e)
        {
            Control.Backup();
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            Control.Undo();
            textBoxNumber.Text = Control.originator.GetData();
        }
    }
}