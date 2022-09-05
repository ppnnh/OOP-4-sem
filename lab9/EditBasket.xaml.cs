using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using static lab6_7.AddGood;

namespace lab6_7
{
    /// <summary>
    /// Логика взаимодействия для EditBasket.xaml
    /// </summary>
    public partial class EditBasket : Window
    {
        List<Item> items = new List<Item>();
        public EditBasket()
        {
            InitializeComponent();
            ComboBoxThemes.SelectionChanged += ThemeChange;
            items = XmlSerializeWrapper.Deserialize<List<Item>>("basket.xml");
            ListViewTable.ItemsSource = items;
            //Привязка command
            CommandBinding commandAdd = new CommandBinding();
            commandAdd.Command = ApplicationCommands.New;
            commandAdd.Executed += ButtonAddGood_Click;
            ButtonAddGood.CommandBindings.Add(commandAdd);
            CommandBinding commandHome = new CommandBinding();
            commandHome.Command = NavigationCommands.BrowseHome;
            commandHome.Executed += ButtonBrowseHome_Click;
            ButtonBrowseHome.CommandBindings.Add(commandHome);
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

        private void ButtonOutputBasket_Click(object sender, RoutedEventArgs e)
        {
            OutputGoods window = new OutputGoods();
            window.Show();
            this.Hide();
        }

        private void ButtonAddGood_Click(object sender, RoutedEventArgs e)
        {
            AddGood window = new AddGood();
            window.Show();
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
        private void ButtonEditItem_Click(object sender, RoutedEventArgs e)
        {
            EditItem window = new EditItem(items, ListViewTable.SelectedIndex);
            window.Show();
        }

        private void ButtonDeleteItem_Click(object sender, RoutedEventArgs e)
        {
            int counter = 0;
            foreach(var item in items)
            {
                if(counter == ListViewTable.SelectedIndex)
                {
                    items.RemoveAt(counter);
                    XmlSerializeWrapper.Serialize(items, "basket.xml");
                    MessageBox.Show($"Товар {item.NameItem} удалён!");
                    break;
                }
                counter++;
            }
            ListViewTable.ItemsSource = items;
        }

        private void ButtonBrowseHome_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow window = new MainWindow();
            window.Show();
        }
    }
}
