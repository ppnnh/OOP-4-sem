using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab6_7
{
    /// <summary>
    /// Логика взаимодействия для UserTBox_clear.xaml
    /// </summary>
    public partial class UserTBox_clear : UserControl
    {
        public UserTBox_clear()
        {
            InitializeComponent();
        }


        private void buttonTBox_Click(object sender, RoutedEventArgs e)
        {
            userTBox.Text = string.Empty;
            userTBox.Focus();
        }
    }
}
