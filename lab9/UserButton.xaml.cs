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
    /// Логика взаимодействия для UserButton.xaml
    /// </summary>
    public partial class UserButton : UserControl
    {
        public UserButton()
        {
            InitializeComponent();
        }

        public void double_click(object sender, MouseButtonEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.StackPanelMainFrame.Visibility = Visibility.Hidden;
            window.StackPanelExitConfirmation.Visibility = Visibility.Visible;
        }
    }
}
