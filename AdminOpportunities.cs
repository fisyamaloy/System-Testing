using System;
using System.Windows.Forms;

namespace Проект.Рестарт
{
    public partial class AdminOpportunities : Form
    {
        public AdminOpportunities()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.CenterToScreen();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            AddStudents NewForm = new AddStudents();
            NewForm.Show();
        }

        private void DeleteStudentsButton_Click(object sender, EventArgs e)
        {
            DeleteStudents NewForm = new DeleteStudents();
            NewForm.Show();
        }

        private void AddTestButton_Click(object sender, EventArgs e)
        {
            CreateTest NewForm = new CreateTest();
            NewForm.Show();
        }

        private void DeleteTestButton_Click(object sender, EventArgs e)
        {
            DeleteTestForm NewForm = new DeleteTestForm();
            NewForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            visibility NewForm = new visibility();
            NewForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentsInfoForm NewForm = new StudentsInfoForm();
            NewForm.Show();
        }
    }
}
