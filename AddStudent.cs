using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Проект.Рестарт
{
    public partial class AddStudents : Form
    {
        public AddStudents()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.CenterToScreen();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void registration_Click(object sender, EventArgs e)
        {
            DB method = new DB();
            if (RichBox.Text != "")
            {
                List<string> RichBoxData = ListFormation();
                // RichBoxData[0] - userclass;
                // RichboxData[2 * n] - username, where  1 <= n <= RichBoxData.Count - 2;
                // RichboxData[2 * n + 1] - password, where 0 <= n <= RichBoxData.Count - 1.
                try
                {
                    for (int i = 1; i < RichBoxData.Count - 1; i += 2)
                        method.AddToBD("INSERT INTO students (`username`, `password`, `userclass`) VALUES (@username, @password, @userclass)",
                            RichBoxData[i], RichBoxData[i + 1], RichBoxData[0].Trim());
                    DeleteStudents.SetMessaage(label1, "Успешно зарегестрированы!", Color.Green);
                }
                catch
                {
                    DeleteStudents.SetMessaage(label1, "Ошибка!", Color.Red);
                }
            }
        }

        private List<string> ListFormation() //Формирование списка, в котором каждая строка является элементом списка
        {
            List<string> RichBoxData = new List<string>();
            string TemproraryText = "";
            for (int i = 0; i < RichBox.Text.Length; i++)
            {
                TemproraryText += RichBox.Text[i];
                if ((RichBox.Text[i] == Convert.ToChar("\n")) || (i == RichBox.Text.Length - 1))
                {
                    RichBoxData.Add(TemproraryText);
                    TemproraryText = "";
                }
            }
            return RichBoxData;
        }
    }
}
