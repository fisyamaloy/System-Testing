using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Проект.Рестарт
{
    public partial class StudentForm : Form
    {
        private static List<string> TestsNames;
        private static int ButtonLeft = 320;
        private static int ButtonTop = 30;

        public StudentForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.CenterToScreen();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TestsNames = GetTestsNamesListWithNeededVisible();
            ShowTestsButtonsOnForm();
        }

        private List<string> GetTestsNamesListWithNeededVisible()
        {
            DB db = new DB();
            return db.GetDataList("SELECT testname FROM tests WHERE classvisible = '" + Student.Class + "'");
        }

        private void ShowTestsButtonsOnForm()
        {
            foreach (string name in TestsNames)
            {
                GetButton(name);
                ButtonTop += 60;
            }
        }

        private Button GetButton(string TestName)
        {
            Button button = new Button();
            button.Cursor = Cursors.Hand;
            button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button.Size = new Size(237, 52);
            button.Left = ButtonLeft;
            button.Top = ButtonTop;
            button.Text = TestName;
            button.UseVisualStyleBackColor = true;
            Controls.Add(button);
            button.Click += new EventHandler(button_Click);
            return button;
        }

        private void button_Click(object sender, EventArgs e)
        {
            ((Form)((Button)sender).Parent).Close();
            DB db = new DB();
            Button button = (Button)sender;
            int ID = Convert.ToInt32(db.GetValue("SELECT id FROM tests WHERE testname = '" + button.Text + "'"));
            List<string> Questions = db.GetDataList("SELECT question_name FROM questions WHERE parent_test = '" + ID + "'");
            double TimeBeforeEndTest = Convert.ToDouble(db.GetValue("SELECT testtimer FROM tests"));
            Test.initialisation(ID, button.Text, Questions, TimeBeforeEndTest);
        }
    }

    public static class Test
    {
        private static string Name;
        private static List<string> Questions;
        private static int ActiveQuestionIndex = 0;
        private static int ID;
        private static double TimeBeforeEndTest;

        private static int _questionID;
        private static double _mark = 0;
        private static Form _questionForm;
        private static CheckedListBox _answersListBox;
        private static Timer _timer;
        private static Label _timerTimeLabel;
        private static DB _db = new DB();

        public static void initialisation(int id, string name, List<string> questions, double time)
        {
            ID = id;
            Name = name;
            Questions = questions;
            TimeBeforeEndTest = time;
            Shuffle();
            ShowQuestionFormAndAnswers();
            TimerAction();
        }

        public static void TimerAction()
        {
            _timer = new Timer();
            _timer.Enabled = true;
            _timer.Interval = 1000;
            _timer.Tick += new EventHandler(_timer_Tick);
            _timer.Start();
        }

        private static void _timer_Tick(object sender, EventArgs e)
        {
            if (TimeBeforeEndTest > 0)
            {
                TimeBeforeEndTest--;
                _timerTimeLabel.Text = "До конца теста осталось " + TimeBeforeEndTest + " секунд(ы)";
            }
            else
            {
                _timer.Stop();
                _mark = (int)(100 / Questions.Count * _mark);
                InsertInformationToDB();
                CloseApp();
                DisplayMarkResult();
            }
        }

        public static void Shuffle()
        {
            Random RandomListIndex = new Random();
            for (int i = Questions.Count - 1; i >= 1; i--)
            {
                int j = RandomListIndex.Next(i + 1);
                string tmp = Questions[j];
                Questions[j] = Questions[i];
                Questions[i] = tmp;
            }
        }

        public static void ShowQuestionFormAndAnswers()
        {
            if (ActiveQuestionIndex < Questions.Count)
            {
                ShowQuestionFormAndInitialField();
                AddDataToForm();
                ActiveQuestionIndex++;
            }
        }

        private static void ShowQuestionFormAndInitialField()
        {

            _questionForm = new Form();
            _questionForm.MaximizeBox = false;
            _questionForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _questionForm.Size = new Size(1280, 720);
            _questionForm.Show();
        }

        private static void AddDataToForm()
        {
            _questionID = Convert.ToInt32(_db.GetValue("SELECT id FROM questions WHERE question_name = '" + Questions[ActiveQuestionIndex] + "'"));
            CreateAndShowQuestionNameLabel();
            CreateAndDisplayTimerTime();
            List<string> answers = _db.GetDataList("SELECT answer FROM answers WHERE parent_question = '" + _questionID + "'");
            CreateAndShowListBox(answers);
            CreateAndShowContinueButton();
        }

        private static void CreateAndShowQuestionNameLabel()
        {
            Label question = new Label();
            question.FlatStyle = FlatStyle.Flat;
            question.Size = new Size(600, 40);
            question.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            question.Location = new Point(40, 40);
            question.Text = (ActiveQuestionIndex + 1) + "/" + Questions.Count + ": " + Questions[ActiveQuestionIndex];
            _questionForm.Controls.Add(question);
        }

        private static void CreateAndDisplayTimerTime()
        {
            _timerTimeLabel = new Label();
            _timerTimeLabel.FlatStyle = FlatStyle.Flat;
            _timerTimeLabel.Size = new Size(600, 40);
            _timerTimeLabel.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _timerTimeLabel.Location = new Point(40, 600);
            _timerTimeLabel.Text = "До конца теста осталось " + TimeBeforeEndTest + " секунд(ы)";
            _questionForm.Controls.Add(_timerTimeLabel);
        }

        private static void CreateAndShowListBox(List<string> answers)
        {
            _answersListBox = new CheckedListBox();
            _answersListBox.CheckOnClick = true;
            _answersListBox.ColumnWidth = 700;
            _answersListBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _answersListBox.FormattingEnabled = true;
            _answersListBox.Location = new Point(40, 100);
            _answersListBox.MultiColumn = true;
            _answersListBox.Size = new Size(471, 510);
            _answersListBox.Items.AddRange(answers.ToArray());
            _questionForm.Controls.Add(_answersListBox);
        }

        private static void CreateAndShowContinueButton()
        {
            Button ContinueButton = new Button();
            ContinueButton.Cursor = Cursors.Hand;
            ContinueButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ContinueButton.Size = new Size(237, 52);
            ContinueButton.Left = 600;
            ContinueButton.Top = 550;
            ContinueButton.Text = "Далее";
            ContinueButton.UseVisualStyleBackColor = true;
            _questionForm.Controls.Add(ContinueButton);
            ContinueButton.Click += new EventHandler(ContinueButton_Click);
        }

        private static void ContinueButton_Click(object sender, EventArgs e)
        {
            GetListsAndSetMarkForQuestion();
            if (itWasLastQuestion())
            {
                _mark = (int)(100 / Questions.Count * _mark);
                InsertInformationToDB();
                CloseApp();
                DisplayMarkResult();
            }
            _questionForm.Close();
            ShowQuestionFormAndAnswers();
        }

        private static bool itWasLastQuestion()
        {
            return ActiveQuestionIndex == Questions.Count;
        }

        private static void GetListsAndSetMarkForQuestion()
        {
            List<string> CorrectAnswers = GetCorrectAnswersOfQuestion();
            List<string> SelectedAnswers = GetSelectedAnswersOfListBox();
            SetMark(CorrectAnswers, SelectedAnswers);
        }

        private static void InsertInformationToDB()
        {
            _db.AddToBD("INSERT INTO results (`studentclass`, `studentname`, `testname`, `mark`) VALUES (@studentclass, @studentname, @testname, @mark)", 
                Student.Class, Student.Login, Test.Name, Test._mark.ToString());
        }

        private static void CloseApp()
        {
            _questionForm.Close();
            Form1 NewForm = new Form1();
            NewForm.Close();
        }

        private static List<string> GetCorrectAnswersOfQuestion()
        {
            return _db.GetDataList("SELECT answer FROM answers WHERE correct_answer = 1 AND parent_question = '" + _questionID + "'");
        }

        private static List<string> GetSelectedAnswersOfListBox()
        {
            List<string> SelectedAnswers = new List<string>();
            foreach (string answer in _answersListBox.CheckedItems)
                SelectedAnswers.Add(answer);
            return SelectedAnswers;
        }

        private static void SetMark(List<string> CorrectAnswers, List<string> SelectedAnswers)
        {
            double mark = 1;

            if (SelectedAnswers.Count < CorrectAnswers.Count)
            {
                foreach (string CorrectAnswer in CorrectAnswers)
                    if (!SelectedAnswers.Contains(CorrectAnswer))
                        mark -= 0.5;
            }
            else
            {
                foreach (string SelectedAnswer in SelectedAnswers)
                    if (!CorrectAnswers.Contains(SelectedAnswer))
                        mark -= 0.5;
            }

            if (mark > 0)
                _mark += mark;
        }

        private static void DisplayMarkResult()
        {
            MessageBox.Show("Количество набранных баллов: " + _mark);
        }
    }
}
