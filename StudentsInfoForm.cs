using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Проект.Рестарт
{
    public partial class StudentsInfoForm : Form
    {
        private readonly DB db = new DB();

        public StudentsInfoForm()
        {
            InitializeComponent();
            AddNamesTestsToComboBox();
            AddClassesToCombobox();
        }

        private void AddNamesTestsToComboBox()
        {
            List<string> TestsNames = db.GetDataList("SELECT testname FROM tests");
            comboBox1.Items.AddRange(TestsNames.ToArray());
        }

        private void AddClassesToCombobox()
        {
            Classes.Items.AddRange(db.GetClassesList().ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Classes.Text != "")
            {
                dataGridView1.Rows.Clear();
                LoadFromData();
            }
        }

        private void LoadFromData()
        {
            List<string[]> Data = GetResultInfo();
            foreach (string[] elem in Data)
                dataGridView1.Rows.Add(elem);
        }

        private List<string[]> GetResultInfo()
        {
            List<string[]> Data = new List<string[]>();
            DB db = new DB();
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("SELECT studentname, mark FROM results WHERE studentclass = " + Classes.Text + " AND testname = '" + comboBox1.Text + "'", db.GetConnection());

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Data.Add(new string[2]);
                Data[Data.Count - 1][0] = reader[0].ToString(); // studentname. 
                Data[Data.Count - 1][1] = reader[1].ToString(); // Result of selected test.
            }
            reader.Close();
            db.CloseConnection();

            return Data;
        }
    }
}
