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
    public partial class DeleteTestForm : Form
    {
        private DB db = new DB();

        public DeleteTestForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.CenterToScreen();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            List<string> tests = db.GetDataList("SELECT testname FROM tests");
            foreach (string name in tests)
                NameTestsBox.Items.Add(name);
        }

        private void DeleteTestForm_Load(object sender, EventArgs e)
        {
            
        }

        private void DelTest_Click(object sender, EventArgs e)
        {
            //id теса
            string IdTest = db.GetValue("SELECT id FROM tests WHERE testname = '" + NameTestsBox.Text + "'");
            //удаляю тест
            db.DeleteFromBD("DELETE FROM tests WHERE testname = '" + NameTestsBox.Text + "'");
            //коллекция вопросов
            List<string> QuestionsNames = db.GetDataList("SELECT question_name FROM questions WHERE parent_test = '" +  IdTest + "'");
            //для каждого вопроса нахожу айди и удаляю ответы
            foreach (string question in QuestionsNames)
            {
                string IdQuestion = db.GetValue("SELECT id FROM questions WHERE question_name = '" + question + "'");
                db.DeleteFromBD("DELETE FROM answers WHERE parent_question = '" + IdQuestion + "'");
                db.DeleteFromBD("DELETE FROM questions WHERE question_name = '" + question + "'");
            }
            NameTestsBox.Text = "";
            NameTestsBox.Items.Remove(NameTestsBox.Text);
        }
    }
}
