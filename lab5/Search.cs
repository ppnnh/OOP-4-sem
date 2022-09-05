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
    public partial class Search : Form
    {
        SearchType SearchType;
        ListView ListView;

        public Search(SearchType searchType, ListView listView)
        {
            InitializeComponent();
            SearchType = searchType;
            ListView = listView;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ListView.Items.Clear();
            ListView.Items.AddRange(Control.SearchInfo(textBoxInfoForSearch.Text, SearchType));
            Close();
        }
    }
}
