using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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
using System.Windows.Resources;
using System.Windows.Shapes;
using static lab6_7.AddGood;

namespace lab6_7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ComboBoxThemes.SelectionChanged += ThemeChange;
            App.LanguageChanged += LanguageChanged;
            CultureInfo currLang = App.Language;
            ObservableCollection<Item> items = new ObservableCollection<Item>();
            // if u run this app first time delete commentary below;
           // XmlSerializeWrapper.Serialize(items, "basket.xml"); 
        }


        private void LanguageChanged(Object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;
        }

        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            string theme = null;
            if (ComboBoxThemes.SelectedIndex == 0)
                theme = "Resources/LightTheme";
            if (ComboBoxThemes.SelectedIndex == 1)
                theme = "Resources/DarkTheme";
            var uri = new Uri(theme + ".xaml", UriKind.Relative);
            ResourceDictionary resourceDictionary = (ResourceDictionary)Application.LoadComponent(uri);
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);
        }

        private void ButtonAddGood_Click(object sender, RoutedEventArgs e)
        {
            AddGood windowAddGood = new AddGood();
            windowAddGood.Show();
            this.Hide();
        }

        private void ButtonEN_click(object sender, RoutedEventArgs e)
        {
            CultureInfo lang = new CultureInfo("en-US");
            App.Language = lang;
        }

        private void ButtonRU_Click(object sender, RoutedEventArgs e)
        {
            CultureInfo lang = new CultureInfo("ru-RU");
            App.Language = lang;
        }

        private void ButtonEditBasket_Click(object sender, RoutedEventArgs e)
        {
            EditBasket window = new EditBasket();
            window.Show();
            this.Hide();
        }

        private void ButtonOutputBasket_Click(object sender, RoutedEventArgs e)
        {
            OutputGoods window = new OutputGoods();
            window.Show();
            this.Hide();
        }

        private void ButtonExitApplication_Click(object sender, RoutedEventArgs e)
        {
            StackPanelExitConfirmation.Visibility = Visibility.Visible;
            StackPanelMainFrame.Visibility = Visibility.Hidden;
        }

        private void CustomControlTextBoxExit_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CustomControlTextBoxExit.Text == "EXIT")
                Close();
        }

        private void ButtonCancelExit_Click(object sender, RoutedEventArgs e)
        {
            StackPanelExitConfirmation.Visibility = Visibility.Hidden;
            StackPanelMainFrame.Visibility = Visibility.Visible;
        }
    }
}
