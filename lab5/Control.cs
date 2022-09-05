using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Laba_2
{
    internal static class Control
    {
        static List<Bill> bills = new List<Bill>();
        static List<Bill> billsInfo = new List<Bill>();
        static Owner _owner = null;
        static DataContractJsonSerializer jsonS = new DataContractJsonSerializer(typeof(List<Bill>));
        public static Originator originator;
        static Caretaker caretaker;

        public static Owner Owner 
        { 
            get => _owner;
        }
        
        public static void Loading(TextBox textBox)
        {
            try
            {
                using (FileStream fs = new FileStream("Счета.json", FileMode.Open))
                {
                    bills = (List<Bill>)jsonS.ReadObject(fs);
                }

                originator = new Originator("");
                caretaker = new Caretaker(originator);
            }
            catch (Exception)
            {

            } 
        }

        public static void ChangeText(string text)
        {
            originator.ChangeText(text);
        }

        public static void Undo()
        {
            caretaker.Undo();
        }

        public static void Backup()
        {
            caretaker.Backup();
        }

        public static void AddBill(Bill bill)
        {
            bills.Add(bill);
            _owner = null;
        }

        public static Bill Factory(AbstractFactory factory)
        {
            return factory.CreateBill();
        }

        public static void AddOwner(Owner owner)
        {
            _owner = owner;        
        }

        public static bool Validate(object obj)
        {
            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(obj, null, null);

            if (!Validator.TryValidateObject(obj, context, results, true))
            {
                foreach (var item in results)
                {
                    MessageBox.Show(item.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return false;
            }

            return true;
        }

        public static void SaveToFile()
        {
            using (FileStream fs = new FileStream("Счета.json", FileMode.Create))
            {
                jsonS.WriteObject(fs, bills);
            }
        }

        public static ListViewItem[] FillInfo()
        {
            billsInfo.Clear();
            billsInfo.AddRange(bills);
            return InfoAssembling(bills);
        }

        private static ListViewItem[] InfoAssembling(List<Bill> BillList)
        {
            ListViewItem[] ResultBills = new ListViewItem[BillList.Count];

            for (int i = 0; i < BillList.Count; i++)
            {
                string[] billStr =
                {
                    BillList[i].Number,
                    BillList[i].Balance.ToString(),
                    BillList[i].OpeningDate.Value.ToShortDateString(),
                    BillList[i].Owner.FullName,
                    BillList[i].Owner.Birthday.Value.ToShortDateString(),
                    BillList[i].Owner.Passport,
                    BillList[i].InternetBankAlert.ToString(),
                    BillList[i].SMSAlert.ToString()
                };

                ResultBills[i] = new ListViewItem(billStr);
            }

            return ResultBills;
        }

        public static ListViewItem[] SearchInfo(string Number, SearchType searchType)
        {
            IEnumerable<Bill> list = bills;

            switch (searchType)
            {
                case SearchType.Номер:
                    list = bills.Where(x => x.Number.Contains(Number)).Select(x => x);
                    break;

                case SearchType.ФИО:
                    list = bills.Where(x => x.Owner.FullName.Contains(Number)).Select(x => x);
                    break;
                case SearchType.Баланс:
                    list = bills.Where(x => x.Balance.ToString().Contains(Number)).Select(x => x);
                    break;

                default:
                    break;
            }

            billsInfo.Clear();
            foreach (var item in list)
            {
                billsInfo.Add(item);
            }

            return InfoAssembling(billsInfo);
        }

        public static ListViewItem[] SortInfo(SortType sortType)
        {
            IEnumerable<Bill> list = bills;

            switch (sortType)
            {
                case SortType.Дата_открытия:
                    list = bills.OrderBy(x => x.OpeningDate).Select(x => x);
                    break;

                default:
                    break;
            }

            billsInfo.Clear();
            foreach (var item in list)
            {
                billsInfo.Add(item);
            }

            return InfoAssembling(billsInfo);
        }

        public static void SaveToFileSample(ListView listView)
        {
            List<Bill> billsToSave = new List<Bill>();
            for (int i = 0; i < listView.Items.Count; i++)
            {
                if (listView.Items[i].Checked)
                {
                    billsToSave.Add(billsInfo[i]);
                }
            }
            
            if (billsToSave.Count > 0)
            {
                using (FileStream fs = new FileStream("Выборка.json", FileMode.Create))
                {
                    jsonS.WriteObject(fs, billsToSave);
                }
            }
            else
            {
                MessageBox.Show("В выборке нет записей");
            }
        }

        public static ListViewItem[] ReadFromFileSample()
        {
            try
            {
                using (FileStream fs = new FileStream("Выборка.json", FileMode.Open))
                {
                    billsInfo.Clear();
                    billsInfo.AddRange((List<Bill>)jsonS.ReadObject(fs));
                    return InfoAssembling(billsInfo);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Файл не существует");
                return InfoAssembling(bills);
            }
        }

        public static void DeleteBills(ListView listView)
        {
            for (int i = 0, j = 0; i < listView.Items.Count; i++)
            {
                if (listView.Items[i].Checked)
                {
                    bills.Remove(billsInfo[i - j++]);
                    listView.Items[i].Remove();
                }
            }

            SaveToFile();

            try
            {
                using (FileStream fs = new FileStream("Выборка.json", FileMode.Open))
                {
                    List<Bill> TempForSample = (List<Bill>)jsonS.ReadObject(fs);

                    for (int i = 0, j = 0; i < listView.Items.Count; i++)
                    {
                        if (listView.Items[i].Checked)
                        {
                            TempForSample.Remove(billsInfo[i - j]);
                            billsInfo.Remove(billsInfo[i - j++]);
                        }
                    }

                    using (FileStream fs2 = new FileStream("Выборка.json", FileMode.Create))
                    {
                        if (TempForSample.Count > 0)
                        {
                            jsonS.WriteObject(fs2, TempForSample);
                        }
                    }
                }
            }
            catch (Exception)
            {
               
            }
        }

        public static string GlobalInfoChange()
        {
            return $"{DateTime.Now}\nКол-во объектов: {bills.Count}\n";
        }
    }
}
