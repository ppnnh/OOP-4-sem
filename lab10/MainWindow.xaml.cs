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
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Net.Mail;
using Microsoft.Win32;
using System.Configuration;

namespace Lab10
{
    public partial class MainWindow : Window
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString; 
        string sqlExpression;
        public SqlConnection connection;
        public SqlCommand command;
        SqlDataReader reader;
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Нет соединения с БД");
                return;
            }
            StudentRead();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MailAddress mailreg;
            try
            {
                mailreg = new MailAddress(EmailBox.Text);
                sqlExpression = $"INSERT INTO Student (Email, Password, Firstname, Secondname, Age, Specialization, Course, Image) VALUES ('{EmailBox.Text}', '{PasswordBox.Text}', '{FirstnameBox.Text}', '{LastnameBox.Text}','{AgeBox.Text}' , '{SpecializationBox.Text}' , '{CourseBox.Text}' , '{WayToPicBox.Text}')";
                command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
                StudentRead();
            }
            catch
            {
                MessageBox.Show("Ошибка добавления");
                return;
            }
        }
        public void StudentRead()
        {
            sqlExpression = "SELECT * FROM Student"; 
            command = new SqlCommand(sqlExpression, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Student> list = new List<Student>();
            if (reader.HasRows) 
            {
                while (reader.Read()) 
                {
                    
                    object id = reader.GetValue(0);
                    object email = reader.GetValue(1);
                    object password = reader.GetValue(2);
                    object firstname = reader.GetValue(3);
                    object secondname = reader.GetValue(4);
                    object age = reader.GetValue(5);
                    object specialization = reader.GetValue(6);
                    object course = reader.GetValue(7);
                    object pic = reader.GetValue(8);
                    Student u = new Student() { ID = Convert.ToInt32(id), Email = email.ToString(), Password = password.ToString(), Firstname = firstname.ToString(), Secondname = secondname.ToString(), Age = Convert.ToInt32(age), Specialization=specialization.ToString(), Course=Convert.ToInt32(course), Image = pic.ToString()};
                  
                    list.Add(u);  
                }
                StudentList.ItemsSource = list;
            }
            reader.Close();
        }
        private int SearchStudent(string ItemFromList) 
        {
            sqlExpression = "SELECT * FROM Student"; 
            command = new SqlCommand(sqlExpression, connection);
            reader = command.ExecuteReader();
            if (reader.HasRows) 
            {
                while (reader.Read()) 
                {
                    
                    object id = reader.GetValue(0);
                    object email = reader.GetValue(1);
                    object password = reader.GetValue(2);
                    object firstname = reader.GetValue(3);
                    object secondname = reader.GetValue(4);
                    object age = reader.GetValue(5);
                    object specialization = reader.GetValue(6);
                    object course = reader.GetValue(7);
                    object pic = reader.GetValue(8);
                    if (ItemFromList == $"{id} {email} {password} {firstname} {secondname} {age} {specialization} {course} {pic}")
                    {
                        return Convert.ToInt32(id);
                    };
                }
                MessageBox.Show("Странно, такого элемента нет");
                return 0;
            }
            MessageBox.Show("Данных нет в бд");

            return 0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) 
        {
            if(StudentList.SelectedItem == null)
            {
                MessageBox.Show("Выберите элемент для удаления");
                return;
            }
            int foundID = SearchStudent(StudentList.SelectedItem.ToString());
            reader.Close();
            sqlExpression = $"Delete from Student where ID = {foundID}";
            command = new SqlCommand(sqlExpression, connection);
            command.ExecuteNonQuery();
            StudentRead();
            reader.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           if(StudentList.SelectedItem == null)
            {
                MessageBox.Show("Выберите элемент для редактирования");
                return;
            }
            int foundID = SearchStudent(StudentList.SelectedItem.ToString());
            reader.Close();
            Edit wnd = new Edit(this, foundID);
            wnd.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openwnd = new OpenFileDialog();
            openwnd.ShowDialog();
            string filename = openwnd.FileName;
            WayToPicBox.Text = filename;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) //добавление в команду
        {
            if (WhomBox.Text == "" && ToWhomBox.Text == "" || WhomBox.Text ==  ToWhomBox.Text)
            {
                MessageBox.Show("Одно из полей пустое или два поля одинаковы");
                return;
            }
            sqlExpression = "Select IDStudent1, IDStudent2 from Worker";
            command = new SqlCommand(sqlExpression, connection);
            reader = command.ExecuteReader();
            if (reader.HasRows) 
            {
                while (reader.Read()) 
                {
                    object u_who = reader.GetValue(0);
                    object who = reader.GetValue(1);
                    if(WhomBox.Text == u_who.ToString() && ToWhomBox.Text == who.ToString())
                    {
                        MessageBox.Show("Такая команда уже есть..");
                        reader.Close();
                        return;
                    }
                }
            }
            reader.Close();
            try
            {
                sqlExpression = $"Insert into Worker(IDStudent1, IDStudent2) Values ({Convert.ToInt32(WhomBox.Text)},{Convert.ToInt32(ToWhomBox.Text)})";
                command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Пользователя с таким ID нет!");
                return;
            }
        }

        private void WhomBox_TextChanged(object sender, TextChangedEventArgs e) 
        {
            TextBox textBox = sender as TextBox;
            Int32 selectionStart = textBox.SelectionStart;
            Int32 selectionLength = textBox.SelectionLength;
            String newText = String.Empty;
            int count = 0;
            foreach (Char c in textBox.Text.ToCharArray())
            {
                if (Char.IsDigit(c) || Char.IsControl(c) || (c == '.' && count == 0))
                {
                    newText += c;
                    if (c == '.')
                        count += 1;
                }
            }
            textBox.Text = newText;
            textBox.SelectionStart = selectionStart <= textBox.Text.Length ? selectionStart : textBox.Text.Length;
        }
        private void OutputWorker_Click(object sender, RoutedEventArgs e)
        {
            if(EnterStudentBox.Text == "")
            {
                MessageBox.Show("Ничего нет в поле, введите ID");
                return;
            }
            StudentOutputList.Items.Clear();
            try
            {
                sqlExpression = $"Select Worker.IDStudent1, Student.Firstname, Student.Secondname from Worker, Student where Worker.IDStudent1 = Student.ID and IDStudent2 = {EnterStudentBox.Text}";
                command = new SqlCommand(sqlExpression, connection);
                reader = command.ExecuteReader();
            }
            catch
            {
                MessageBox.Show("Пользователя с таким ID нет!");
                return;
            }
            while (reader.Read())
            {
                object id = reader.GetValue(0);
                object firstname = reader.GetValue(1);
                object secondname = reader.GetValue(2);
                StudentOutputList.Items.Add($"{id} {firstname} {secondname}");
            }
            reader.Close();
        }

        private void Image_PreviewMouseLeftButtonDown(object sender, RoutedEventArgs e)
        {

        }
    }
}
