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
    public enum SearchType
    {
        Номер,
        ФИО,
        Баланс,
        Тип_вклада
    }

    public enum SortType
    {
        Тип_вклада,
        Дата_открытия
    }

    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            listViewInfo.Items.AddRange(Control.FillInfo());
        }

        private void Info_Load(object sender, EventArgs e)
        {

        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search((SearchType)Convert.ToInt32(((ToolStripMenuItem)sender).Tag), listViewInfo);
            search.ShowDialog();
        }

        private void сортировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewInfo.Items.Clear();
            listViewInfo.Items.AddRange(Control.SortInfo((SortType)Convert.ToInt32(((ToolStripMenuItem)sender).Tag))); 
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control.SaveToFileSample(listViewInfo);
        }

        private void вывестиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewInfo.Items.Clear();
            listViewInfo.Items.AddRange(Control.ReadFromFileSample());
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control.DeleteBills(listViewInfo);
        }
    }
}
