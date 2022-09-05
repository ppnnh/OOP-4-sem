using Lab_11.Context;
using Lab_11.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Lab_11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyDb mdb;
        public MainWindow()
        {
            InitializeComponent();

            mdb = new MyDb();



            Plane a = new Plane { id = 1, model = "Airbus" };
            mdb.Plane.Add(a);
            mdb.SaveChanges();
            //Worker worker = new Worker { id = 1, name = "Tom", planeId = 1 };

            //a.Workers.Add(worker);
            //pc.Plane.Add(a);
            //wc.Worker.Add(worker);

            //pc.SaveChanges();
            //wc.SaveChanges();

            workerGrid.ItemsSource = mdb.Worker.Local.ToBindingList();

            this.Closing += MainWindow_Closing;
        }
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mdb.Dispose();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            mdb.SaveChanges();
            mdb.Worker.Load();
            workerGrid.ItemsSource = mdb.Worker.Local.ToBindingList();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (workerGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < workerGrid.SelectedItems.Count; i++)
                {
                    Worker worker = workerGrid.SelectedItems[i] as Worker;
                    if (worker != null)
                    {
                        mdb.Worker.Remove(worker);
                    }
                }
            }
            mdb.SaveChanges();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            AddWorkerWindow win = new AddWorkerWindow();
            win.ShowDialog();
        }

        private void queryButton_Click(object sender, RoutedEventArgs e)
        {
            Worker.GetNameById(1);
        }

    }
}
