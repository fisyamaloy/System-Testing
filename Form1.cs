using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект.Рестарт
{
    public partial class Form1 : Form
    {
        public struct Students
        {
            public string Login { get; set; }
            public string Password { get; set; }
            public string UserClass { get; set; }
            public Students(string Login, string Password, string UserClass)
            {
                this.Login = Login;
                this.Password = Password;
                this.UserClass = UserClass;
            }
        }

        private List<Students> StudentsData;

        private bool CheckConnection;

        public Form1()
        {
            InitializeComponent();
            CheckConnection = true;
            this.MaximizeBox = false;
            this.CenterToScreen();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            StudentsData = new List<Students>();
            try
            {
                FullStudentsDataList();
            }
            catch
            {
                CheckConnection = false;
            }
            timer1.Start();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckConnection)
            {
                UserVerificatioAndLogin();
                timer1.Stop();
            }
            else
                ShowErrorMessage();
        }

        private void UserVerificatioAndLogin()
        {
            bool flag = false;
            if (login.Text.Trim().Equals("admin") && password.Text.Equals("19967340"))
            {
                AdminOpportunities NewForm = new AdminOpportunities();
                NewForm.Show();
                Hide();
            }
            else
            // Значит это не администратор.
            {
                for (int i = 0; i < StudentsData.Count; i++)
                {
                    if (login.Text.Equals(StudentsData[i].Login.Trim()) && password.Text.Equals(StudentsData[i].Password.Trim()))
                    {
                        flag = true;
                        FullInformationOfEnteredStudent(StudentsData[i].UserClass);
                        HideThisFormAndShowStudentForm();
                        break;
                    }
                }
                if (!flag)
                    DeleteStudents.SetMessaage(label1, "Неправильно введен логин или пароль!", Color.Red);
            }
        }

        private void FullInformationOfEnteredStudent(string Class)
        {
            Student.Login = login.Text;
            Student.Password = password.Text;
            Student.Class = Class;
        }

        private void HideThisFormAndShowStudentForm()
        {
            StudentForm NewForm = new StudentForm();
            NewForm.Show();
            Hide();
        }

        private void FullStudentsDataList()
        {
            DB db = new DB();
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM students", db.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();
            // Формирую объекты c логином и паролем.
            while (reader.Read())
                StudentsData.Add(new Students(reader[1].ToString(), reader[2].ToString(), reader[3].ToString()));
            reader.Close();
            db.CloseConnection();
        }

        private void login_MouseClick(object sender, MouseEventArgs e)
        {
            label2.Text = "";
        }

        private void password_MouseClick(object sender, MouseEventArgs e)
        {
            label3.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!CheckConnection)
                ShowErrorMessage();
        }

        private void ShowErrorMessage()
        {
            DialogResult result = MessageBox.Show("Отсутсвует потключение к серверу! Выйти из приложения?", "Ошибка!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
                Close();
        }
    }

    public static class Student
    {
        public static string Login { get; set; }
        public static string Password { get; set; }
        public static string Class { get; set; }
    }
}
