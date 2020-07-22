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
    public partial class visibility : Form
    {
        DB db = new DB();
        public visibility()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.CenterToScreen();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            List<string> classes = db.GetClassesList();
            foreach (string name in classes)
                ClassesCombBox.Items.Add(name);
            List<string> tests = db.GetDataList("SELECT testname FROM tests");
            foreach (string name in tests)
                NameTestsBox.Items.Add(name);
        }

        private void isAssigned_CheckedChanged(object sender, EventArgs e)
        {
            if (ClassesCombBox.Text != "" && NameTestsBox.Text != "")
                db.SetValue("UPDATE tests SET classvisible = '" + ClassesCombBox.Text + "' WHERE testname = '" + NameTestsBox.Text + "'");
        }

        private void isNotAssigned_CheckedChanged(object sender, EventArgs e)
        {
            if (ClassesCombBox.Text != "" && NameTestsBox.Text != "")
                db.SetValue("UPDATE tests SET classvisible = 0 WHERE testname = '" + NameTestsBox.Text + "'");
        }

        private void ClassesCombBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClassesCombBox.Text != "" && NameTestsBox.Text != "")
                SetStartedVisible();
        }

        private void NameTestsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClassesCombBox.Text != "" && NameTestsBox.Text != "")
                SetStartedVisible();
        }

        private void SetStartedVisible()
        {
            string assigning = db.GetValue("SELECT classvisible FROM tests WHERE testname = '" + NameTestsBox.Text + "'");
            if (assigning == "0")
                isNotAssigned.Checked = true;
            else
                isAssigned.Checked = true;
        }
    }
}
