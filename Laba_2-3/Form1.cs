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
            bool? sms;
            if (radioButtonYes.Checked == radioButtonNo.Checked)
            {
                sms = null;
            }
            else
            {
                sms = radioButtonYes.Checked;
            }

            Bill.BillType? billtype;
            if (comboBoxBillType.SelectedIndex == -1)
            {
                billtype = null;
            }
            else
            {
                billtype = (Bill.BillType)comboBoxBillType.SelectedIndex;
            }

            Bill bill = new Bill(textBoxNumber.Text, billtype, numericUpDownBalance.Value,
                dateTimePickerOprningDate.Value.Date, Control.Owner, checkBoxYes.Checked, sms);

            if (Control.Validate(bill))
            {
                Control.AddBill(bill);
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
            MessageBox.Show("Version 0.0001\nBuranko V.D.", "О программе");
        }
    }
}