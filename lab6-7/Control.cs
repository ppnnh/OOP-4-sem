﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Laba_6_7
{
    internal static class Control
    {
        public static BindingList<Product> BLProducts = new BindingList<Product>();
        public static List<Product> Products = new List<Product>();
        public static Product Product = new Product();
        static DataContractJsonSerializer jsonS = new DataContractJsonSerializer(typeof(List<Product>));
        public static ListView listView = new ListView();

        public static void Loading(ListView _listView)
        {
            ReadFromFile();
            listView = _listView;
            RefreshList(Products);
        }

        private static void SaveToFile()
        {
            using (FileStream fs = new FileStream("Products.json", FileMode.Create))
            {
                jsonS.WriteObject(fs, Products);
            }
        }

        private static void ReadFromFile()
        {
            try
            {
                using (FileStream fs = new FileStream("Products.json", FileMode.Open))
                {
                    Products = (List<Product>)jsonS.ReadObject(fs);
                }
            }
            catch (Exception)
            {

            }
        }

        public static void AddProduct(Product Product)
        {
            Products.Add(Product);
            SaveToFile();
            RefreshList(Products);
        }

        public static void DeleteProduct()
        {
            Products.Remove(Product);
            SaveToFile();
            RefreshList(Products);
        }

        public static void RefreshList(List<Product> list)
        {
            BLProducts.Clear();
            foreach (var item in list)
            {
                BLProducts.Add(item);
            }
            listView.ItemsSource = BLProducts;
        }
    }
}
