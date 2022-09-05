using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Lab10
{
    /// <summary>
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        MainWindow mainwnd;
        int foundId;
        string sqlExpression;


        public Edit(MainWindow main, int id)
        {
            InitializeComponent();
            mainwnd = main;
            foundId = id;
            sqlExpression = $"select * from Student where ID = {foundId}";
            mainwnd.command = new SqlCommand(sqlExpression, mainwnd.connection);
            OutPut();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Text == "" && FirstNameBox.Text == "" && LastNameBox.Text == "")
            {
                MessageBox.Show("Есть пустые поля");
                return;
            }
            sqlExpression = $"Update Student Set Password = '{PasswordBox.Text}', Firstname = '{FirstNameBox.Text}', Secondname = '{LastNameBox.Text}' where ID = {foundId}";
            mainwnd.command = new SqlCommand(sqlExpression, mainwnd.connection);
            mainwnd.command.ExecuteNonQuery();
            mainwnd.StudentRead();
            Close();
        }

        void OutPut()
        {
            SqlDataReader reader = mainwnd.command.ExecuteReader();
            object Password = null ;
            object FirstName = null;
            object SecondName = null;
            if (reader.HasRows) // если есть данные
            {
                while (reader.Read()) // построчно считываем данные
                {
                    Password = reader.GetValue(2);
                    FirstName = reader.GetValue(3);
                    SecondName = reader.GetValue(4);
                }
            }
            reader.Close();
            PasswordBox.Text = Password.ToString();
            FirstNameBox.Text = FirstName.ToString();
            LastNameBox.Text = SecondName.ToString(); 
        }
    }
}
