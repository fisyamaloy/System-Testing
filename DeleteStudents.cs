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
    public partial class DeleteStudents : Form
    {
        public DeleteStudents()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.CenterToScreen();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }


        private static DB method = new DB();

        private void DeleteStudents_Load(object sender, EventArgs e)
        {
            List<string> classes = method.GetClassesList();
            foreach (string elem in classes)
                UsersClassesBox.Items.Add(elem);
        }

        private void UsersClassesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UsersListBox.Items.Clear();
            List<string> UsersOfSelectedClass = method.GetDataList("SELECT username FROM students WHERE userclass=" + UsersClassesBox.SelectedItem);
            UsersOfSelectedClass.Sort();
            foreach (string elem in UsersOfSelectedClass)
                UsersListBox.Items.Add(elem);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteUser();
                UsersListBox.Items.Clear();
                SetMessaage(label1, "Удаление произведено успешно!", Color.Green);
            }
            catch
            {
                SetMessaage(label1, "Ошибка!", Color.Red);
            }
        }

        private void DeleteUser()
        {
            DB method = new DB();
            foreach (string selectedItem in UsersListBox.CheckedItems)
                method.DeleteFromBD("DELETE FROM students WHERE username = '" + selectedItem + "'");
        }

        public static void SetMessaage(Label label1, string message, Color color)
        {
            label1.ForeColor = color;
            label1.Text = message;
        }
    }
}
