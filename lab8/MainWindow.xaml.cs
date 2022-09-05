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

namespace Laba_6_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Binding binding = new Binding();
        public MainWindow()
        {
            InitializeComponent();
            Control.Loading(listOfProducts);
            Clear();
            LoadResourceDictionaries();
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            AddAndChangeWindow window = new AddAndChangeWindow();
            window.Show();
        }

        private void SearchProduct_Click(object sender, RoutedEventArgs e)
        {
            SearchWindow searchWindow = new SearchWindow();
            searchWindow.ShowDialog();
        }

        private void Sort_Click(object sender, RoutedEventArgs e)
        {
            SortWindow sortWindow = new SortWindow();
            sortWindow.ShowDialog();
        }

        private void ClearFields_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private void listOfProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FromBingingToProduct();

            infoName.Text = Control.Product.Name;
            infoPrice.Text = Convert.ToString(Control.Product.Price);
            infoTypeOfProduct.Text = Control.Product.TypeOfProduct;
            infoRating.Text = Convert.ToString(Control.Product.Rating);
            infoImage.Source = new BitmapImage(new Uri(Control.Product.PhotoPath, UriKind.Absolute));
            infoDescription.Text = Control.Product.Description;
        }

        private bool FromBingingToProduct()
        {
            if (listOfProducts.SelectedItem != null)
            {
                binding.Source = listOfProducts.SelectedItem;
                Control.Product = listOfProducts.SelectedItem as Product;
                infoDescription.Text = Control.Product.Description;
                return true;
            }

            return false;
        }

        private void Clear()
        {
            infoName.Text = "";
            infoPrice.Text = "";
            infoTypeOfProduct.Text = "";
            infoRating.Text = "";
            infoImage.Source = new BitmapImage(new Uri("D:\\4sem\\ООП\\Laba_8\\Laba_6_7\\Resources\\Apples_Closeup_White_background_Red_548034_5129x3543.jpg", UriKind.Absolute));
            infoDescription.Text = "";
        }

        private void DeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            if (FromBingingToProduct())
            {
                Control.DeleteProduct();
                Clear();
            }
        }

        private void ChangeProduct_Click(object sender, RoutedEventArgs e)
        {
            if (FromBingingToProduct())
            {
                ChangeProduct window = new ChangeProduct();
                window.Show();
            }
        }

        private Uri selectedLanguage = new Uri("Russian.xaml", UriKind.Relative);
        private Uri selectedTheme = new Uri("Theme1.xaml", UriKind.Relative);

        private void SwitchLanguage(object sender, RoutedEventArgs e)
        {
            if (selectedLanguage == new Uri("Russian.xaml", UriKind.Relative))
            {
                selectedLanguage = new Uri("English.xaml", UriKind.Relative);
            }
            else
            {
                selectedLanguage = new Uri("Russian.xaml", UriKind.Relative);
            }
            
            LoadResourceDictionaries();
        }

        private void SwitchToLightTheme(object sender, RoutedEventArgs e)
        {
            selectedTheme = new Uri("Theme1.xaml", UriKind.Relative);
            LoadResourceDictionaries();
        }

        private void SwitchToDarkTheme(object sender, RoutedEventArgs e)
        {
            selectedTheme = new Uri("Theme2.xaml", UriKind.Relative);
            LoadResourceDictionaries();
        }

        private void SwitchToConsoleTheme(object sender, RoutedEventArgs e)
        {
            selectedTheme = new Uri("Theme3.xaml", UriKind.Relative);
            LoadResourceDictionaries();
        }

        private void LoadResourceDictionaries()
        {
            ResourceDictionary language = new ResourceDictionary();
            ResourceDictionary theme = new ResourceDictionary();

            language.Source = selectedLanguage;
            theme.Source = selectedTheme;

            Application.Current.Resources.MergedDictionaries.Add(language);
            Application.Current.Resources.MergedDictionaries.Add(theme);
        }

        private void Redo_Click(object sender, RoutedEventArgs e)
        {
            Control.Redo();
            Clear();
        }

        private void Undo_Click(object sender, RoutedEventArgs e)
        {
            Control.Undo();
            Clear();
        }
    }
}
