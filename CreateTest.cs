using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект.Рестарт
{
    public partial class CreateTest : Form
    {
        public CreateTest()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.CenterToScreen();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private static string path = @"";

        private void SelectTest_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            if (OpenFile.ShowDialog() == DialogResult.OK)
                path = OpenFile.FileName;
        }

        private static DB methods = new DB();
        
        private void ToDownload_Click(object sender, EventArgs e)
        {
            if (path != "")
            {
                try
                {
                    string[] DataFile = File.ReadAllLines(path);
                    string TestName = DataFile[0].Trim();
                    string TestTimer = DataFile[DataFile.Length - 1].Trim();
                    methods.AddToBD("INSERT INTO tests (`testname`, `testtimer`) VALUES (@testname, @testtimer)", TestName, TestTimer);
                    string TestID = methods.GetValue("SELECT id FROM `tests` WHERE testname = '" + TestName + "'");
                    for (int i = 1; i < DataFile.Length - 3; i += 3)
                    {
                        methods.AddToBD("INSERT INTO questions (`question_name`, `parent_test`) VALUES (@question_name, @parent_test)", DataFile[i], TestID);
                        string QuestionID = methods.GetValue("SELECT id FROM questions WHERE question_name = '" + DataFile[i] + "'");
                        AddAnswersToBD(DataFile[i + 1].Trim().Split('|').ToList(), QuestionID, DataFile[i + 2]);
                    }
                    DeleteStudents.SetMessaage(label2, "Тест создан!", Color.Green);
                }
                catch
                {
                    DeleteStudents.SetMessaage(label2, "Ошибка!", Color.Red);
                }
            }
            else
                DeleteStudents.SetMessaage(label2, "Выберите файл!", Color.Red);
            
        }

        private static void AddAnswersToBD(List<string> answers, string QuestionID, string CorrectAnswer)
        {
            foreach (string elem in answers)
            {
                if (CorrectAnswer != elem.Trim())
                    methods.AddToBD("INSERT INTO answers (`answer`, `parent_question`) VALUES (@answer, @parent_question)", elem.Trim(), QuestionID);
                else
                    methods.AddToBD("INSERT INTO answers (`answer`, `parent_question`, `correct_answer`) VALUES (@answer, @parent_question, @correct_answer)",
                        elem.Trim(), QuestionID, "1");
            }
        }
    }
}
