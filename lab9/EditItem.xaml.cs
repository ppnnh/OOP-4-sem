using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для EditItem.xaml
    /// </summary>
    public partial class EditItem : Window
    {
        List<Item> items = new List<Item>();
        int numItem = 0;
        public EditItem()
        {
            InitializeComponent();
        }

        public EditItem(List<Item> items, object numItem)
        {
            InitializeComponent();
            this.items = items;
            this.numItem = (int)numItem;
            int counter = 0;
            foreach (var item in items)
            {
                if (counter == this.numItem)
                {
                    TextBoxNameGood.Text = item.NameItem;
                    TextBoxPrice.Text = item.Price.ToString();
                    TextBoxCountry.Text = item.Country;
                    ComboBoxCategory.Text = item.Category;
                    if (item.IsAvailable == "В НАЛИЧИИ")
                        RadioButtonAvailable.IsChecked = true;
                    else
                        RadioButtonNotAvailable.IsChecked = true;
                    BitmapImage image = new BitmapImage();
                    image.BeginInit();
                    image.UriSource = new Uri(item.PicturePath);
                    image.EndInit();
                    ItemPicture.Source = image;
                    break;
                }
                counter++;
            }
        }

        private void ButtonSaveEditings_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int counter = 0;
                foreach (var item in items)
                {
                    if (numItem == counter)
                    {
                        item.NameItem = TextBoxNameGood.Text;
                        item.Category = ComboBoxCategory.Text;
                        item.Country = TextBoxCountry.Text;
                        if (Double.TryParse(TextBoxPrice.Text, out double result))
                            item.Price = result;
                        item.PicturePath = ItemPicture.Source.ToString();
                        if (RadioButtonAvailable.IsChecked == true)
                            item.IsAvailable = "В НАЛИЧИИ";
                        if (RadioButtonNotAvailable.IsChecked == true)
                            item.IsAvailable = "ОТСУТСТВУЕТ";
                        break;
                    }
                    counter++;
                }
                XmlSerializeWrapper.Serialize(items, "basket.xml");
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка записи в файл!");
                return;
            }
            MessageBox.Show("Информация о товаре изменена!");

            this.Hide();
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
                ItemPicture.Source = image;
            }
        }

        private void TextBoxPrice_KeyDown(object sender, KeyEventArgs e)
        {
            string Symbol = e.Key.ToString();
            if (!Regex.Match(Symbol, @"[0-9]").Success && e.Key != Key.Back && e.Key != Key.OemPeriod && e.Key != Key.OemComma)
            {
                e.Handled = true;
            }
        }
    }
}
