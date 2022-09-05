using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
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
using OOP_LAB_12.Classes;
using OOP_LAB_12.Repository;
using OOP_LAB_12.UOW;

namespace OOP_LAB_12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UnitOfWork<Smartphone> unitSmartphone = new UnitOfWork<Smartphone>();
        UnitOfWork<Provider> unitProvider = new UnitOfWork<Provider>();

        public MainWindow()
        {
            InitializeComponent();
            try
            {
                using (Context.Context context = new Context.Context())
                {
                    var providers = context.Providers.Select(t => t.ProviderName);
                    foreach (var t in providers)
                    {
                        ProviderIdCombo.Items.Add(t);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void CreateProviderButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                unitProvider.CrudRepository.Create(new Provider(Int32.Parse(ProviderId.Text), ProviderName.Text,
                    ProviderLocation.Text));
                //CrudRepository<Provider> crudRepository = new CrudRepository<Provider>(new Context.Context());
                //crudRepository.Create(new Provider(Int32.Parse(ProviderId.Text), ProviderName.Text,ProviderLocation.Text));

                MessageBox.Show("Done");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }

        }

        private void ReadButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                //CrudRepository<Smartphone> crudRepository = new CrudRepository<Smartphone>(new Context.Context());
                //crudRepository.ReadSmartphone(dg_Smartphones);
                unitSmartphone.CrudRepository.ReadSmartphone(dg_Smartphones);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void CreateButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var provider = new Context.Context().Providers.Where(t => t.ProviderName == ProviderIdCombo.Text).Select(t => t.ProviderId).First();
                //CrudRepository<Smartphone> crudRepository = new CrudRepository<Smartphone>(new Context.Context());
                //crudRepository.Create(new Smartphone(Int32.Parse(SmartphoneId.Text), SmartphoneName.Text,
                //    Int32.Parse(YearOfIssue.Text), Double.Parse(Cost.Text), provider));
                unitSmartphone.CrudRepository.Create(new Smartphone(Int32.Parse(SmartphoneId.Text), SmartphoneName.Text, Int32.Parse(YearOfIssue.Text), Double.Parse(Cost.Text), provider));
                MessageBox.Show("Done");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }//crudRepository.GetWithInclude(t => t.Provider.ProviderName == ProviderIdCombo.Text).First(t=> t.ProviderId)

        }

        private void UpdateButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                //CrudRepository<Smartphone> crudRepository = new CrudRepository<Smartphone>(new Context.Context());
                var item = dg_Smartphones.SelectedItem as Smartphone;
                //crudRepository.Update(item);
                unitSmartphone.CrudRepository.Update(item);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Dg_Smartphones_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (dg_Smartphones.SelectedIndex == -1)
                {
                    return;
                }
                var item = dg_Smartphones.SelectedItem as Smartphone;
                SmartphoneId.Text = item.SmartphoneId.ToString();
                SmartphoneName.Text = item.SmartphoneName.ToString();
                YearOfIssue.Text = item.YearOfIssue.ToString();
                Cost.Text = item.Cost.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void DeleteButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                //CrudRepository<Smartphone> crudRepository = new CrudRepository<Smartphone>(new Context.Context());
                var item = dg_Smartphones.SelectedItem as Smartphone;
                //crudRepository.Delete(new Smartphone() {SmartphoneId = item.SmartphoneId});
                unitSmartphone.CrudRepository.Delete(item);
                ReadButton_OnClick(sender, e);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void RestartButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
