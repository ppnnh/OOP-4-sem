using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_2
{
    public partial class CreatingOwner : Form
    {
        public CreatingOwner()
        {
            InitializeComponent();
            dateTimePickerBirthday.MaxDate = new DateTime(DateTime.Now.Year - 18, DateTime.Now.Month, DateTime.Now.Day);
        }

        private void buttonAddOwner_Click(object sender, EventArgs e)
        {
            Owner owner = new Owner(textBoxFullName.Text, dateTimePickerBirthday.Value, textBoxPassport.Text);

            if (Control.Validate(owner))
            {
                Control.AddOwner(owner);
                Close();
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
    }
}
