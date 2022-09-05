using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Xml.Serialization;

namespace lab6_7
{
    /// <summary>
    /// Логика взаимодействия для AddGood.xaml
    /// </summary>
    public partial class AddGood : Window
    {
        List<Item> itemsCollection = new List<Item>();
        List<Item> lastItems = new List<Item>();
        Item lastItem = new Item();
        string imgPathDefault = null;

        public AddGood()
        {
            InitializeComponent();
            ComboBoxThemes.SelectionChanged += ThemeChange;
            itemsCollection = XmlSerializeWrapper.Deserialize<List<Item>>("basket.xml");
            CommandBinding commandHome = new CommandBinding();
            commandHome.Command = NavigationCommands.BrowseHome;
            commandHome.Executed += ButtonBrowseHome_Click;
            ButtonBrowseHome.CommandBindings.Add(commandHome);
            CommandBinding commandEdit = new CommandBinding();
            commandEdit.Command = ApplicationCommands.CorrectionList;
            commandEdit.Executed += ButtonEditBasket_Click;
            ButtonEditBasket.CommandBindings.Add(commandEdit);
        }

        static AddGood()
        {
            List<Item> itemsCollection = new List<Item>();
            List<Item> lastItems = new List<Item>();
            Item lastItem = new Item();

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

        private void ButtonBrowseHome_Click(object sender, ExecutedRoutedEventArgs e)
        {
            this.Hide();
            MainWindow window = new MainWindow();
            window.Show();
        }

        [Serializable]
        public class Item
        {

            [XmlElement(ElementName = "name_of_item")]
            public string NameItem { get; set; }
            [XmlElement(ElementName = "category_of_item")]
            public string Category { get; set; }
            [XmlElement(ElementName = "price_for_one_kg")]
            public double Price { get; set; }
            [XmlElement(ElementName = "origin_country")]
            public string Country { get; set; }
            [XmlElement(ElementName = "is_alailable")]
            public string IsAvailable { get; set; }
            [XmlIgnore]
            public string Description { get; set; }
            [XmlElement(ElementName = "path_of_picture")]
            public string PicturePath { get; set; }
        }

        public static class XmlSerializeWrapper
        {
            public static void Serialize<T>(T obj, string filename)
            {
                XmlSerializer formatter = new XmlSerializer(typeof(T));
                using (FileStream fs = new FileStream(filename, FileMode.Create))
                {
                    formatter.Serialize(fs, obj);
                }
            }
            public static T Deserialize<T>(string filename)
            {
                T obj;
                if (File.Exists(filename))
                {
                    using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(T));
                        obj = (T)serializer.Deserialize(fs);
                    }
                    return obj;
                }
                return default(T);
            }
        }

        private void ButtonRU_Click(object sender, RoutedEventArgs e)
        {
            CultureInfo lang = new CultureInfo("ru-RU");
            App.Language = lang;
        }

        private void ButtonEN_Click(object sender, RoutedEventArgs e)
        {
            CultureInfo lang = new CultureInfo("en-US");
            App.Language = lang;
        }

        public void CommandBinding_Executed(object sender,ExecutedRoutedEventArgs e)
        {
            ButtonBrowseHome_Click(sender, e);
        }

        private void ButtonAddItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Item tempItem = new Item();
                tempItem.NameItem = TextBoxNameItem.userTBox.Text;
                tempItem.Category = ComboBoxCategory.Text;
                if (Double.TryParse(TextBoxPrice.Text, out double price))
                    tempItem.Price = price;
                else
                    throw new Exception("Неверные данные в поле с ценой");
                tempItem.Country = TextBoxCountry.Text;
                if (RadioButtonAvailable.IsChecked == true)
                    tempItem.IsAvailable = TextBlockAvailable.Text;
                if (RadioButtonNotAvailable.IsChecked == true)
                    tempItem.IsAvailable = TextBlockNotAvailable.Text;
                tempItem.Description = TBoxDescription.Content.ToString();
                tempItem.PicturePath = ItemPicture.Source.ToString();
                lastItem = tempItem;
                itemsCollection.Add(tempItem);
                lastItems.Add(tempItem);
                ButtonUndo.IsEnabled = true;
                ButtonRedo.IsEnabled = true;
                XmlSerializeWrapper.Serialize(itemsCollection, "basket.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка записи в файл! \n {ex.Message}");
                return;
            }
            MessageBox.Show($"Товар добавлен в корзину!\nКоличество товаров в корзине : {itemsCollection.Count}\nОтправитель:{sender}\nИсточник:{e.Source}\nПрямое событие Click");

        }

        private void TextBoxPrice_KeyDown(object sender, KeyEventArgs e)
        {
            string Symbol = e.Key.ToString();
            if (!Regex.Match(Symbol, @"[0-9]").Success && e.Key != Key.Back && e.Key != Key.OemPeriod && e.Key != Key.OemComma)
            {
                e.Handled = true;
            }
        }


        private void ButtonEditBasket_Click(object sender, RoutedEventArgs e)
        {
            EditBasket window = new EditBasket();
            window.Show();
            this.Hide();
        }


        private void ButtonOutputBacket_Click(object sender, RoutedEventArgs e)
        {
            OutputGoods window = new OutputGoods();
            window.Show();
            this.Hide();
        }

        private void ButtonUndo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lastItems.RemoveAt(lastItems.Count - 1);
                itemsCollection.RemoveAt(itemsCollection.Count - 1);
                MessageBox.Show($"Последний добавленный элемент ({lastItem.NameItem}) удален!");
                XmlSerializeWrapper.Serialize(itemsCollection, "basket.xml");
            }
            catch (Exception)
            {
                MessageBox.Show("Вы удалили все только что добавленные товары!");
                ButtonUndo.IsEnabled = false;
            }
        }

        private void ButtonRedo_Click(object sender, RoutedEventArgs e)
        {
            itemsCollection.Add(lastItem);
            lastItems.Add(lastItem);
            XmlSerializeWrapper.Serialize(itemsCollection, "basket.xml");
            MessageBox.Show($"Последний добавленный элемент ({lastItem.NameItem}) добавлен!");
        }

        private void LeftButton(object sender, MouseButtonEventArgs e)
        {
            TextBoxPrice.Text = string.Empty;
            TextBoxNameItem.userTBox.Text="";
            TBoxDescription.TBoxDescription.Text = "";
            TextBoxCountry.Text = string.Empty;
            ComboBoxCategory.SelectedIndex = -1;
            RadioButtonAvailable.IsChecked = false;
            RadioButtonNotAvailable.IsChecked = false;
            MessageBox.Show($"Отправитель:{sender}\nИсточник:{e.Source}\nТуннельное событие MouseDown");
        }

        private void ButtonAddPicture_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = ""; // Default file name
            dlg.DefaultExt = ".png"; // Default file extension
                                     //    dlg.Filter = "Pictures (.png,jpg)|*.png,*.jpg"; // Filter files by extension

            // Show open file dialog box
            Nullable<bool> result = dlg.ShowDialog();
            // Process open file dialog box results
            if (result == true)
            {
                // Open document
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(dlg.FileName);
                image.EndInit();
                imgPathDefault = ItemPicture.Source.ToString();
                ItemPicture.Source = image;
            }
            MessageBox.Show($"Отправитель:{sender}\nИсточник:{e.Source}\nПоднимающееся событие");
        }

        private void BubblingEvent(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show($"Отправитель:{sender}\nИсточник:{e.Source}\nПоднимающееся событие");
        }

    }
}
