namespace Проект.Рестарт
{
    partial class AdminOpportunities
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.DeleteStudentsButton = new System.Windows.Forms.Button();
            this.AddTestButton = new System.Windows.Forms.Button();
            this.DeleteTestButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddStudentButton.Location = new System.Drawing.Point(56, 46);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(280, 52);
            this.AddStudentButton.TabIndex = 1;
            this.AddStudentButton.Text = "Добавить учеников";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // DeleteStudentsButton
            // 
            this.DeleteStudentsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteStudentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteStudentsButton.Location = new System.Drawing.Point(441, 46);
            this.DeleteStudentsButton.Name = "DeleteStudentsButton";
            this.DeleteStudentsButton.Size = new System.Drawing.Size(280, 52);
            this.DeleteStudentsButton.TabIndex = 2;
            this.DeleteStudentsButton.Text = "Удалить учеников";
            this.DeleteStudentsButton.UseVisualStyleBackColor = true;
            this.DeleteStudentsButton.Click += new System.EventHandler(this.DeleteStudentsButton_Click);
            // 
            // AddTestButton
            // 
            this.AddTestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTestButton.Location = new System.Drawing.Point(56, 120);
            this.AddTestButton.Name = "AddTestButton";
            this.AddTestButton.Size = new System.Drawing.Size(280, 52);
            this.AddTestButton.TabIndex = 3;
            this.AddTestButton.Text = "Добавить тест";
            this.AddTestButton.UseVisualStyleBackColor = true;
            this.AddTestButton.Click += new System.EventHandler(this.AddTestButton_Click);
            // 
            // DeleteTestButton
            // 
            this.DeleteTestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteTestButton.Location = new System.Drawing.Point(441, 120);
            this.DeleteTestButton.Name = "DeleteTestButton";
            this.DeleteTestButton.Size = new System.Drawing.Size(280, 52);
            this.DeleteTestButton.TabIndex = 4;
            this.DeleteTestButton.Text = "Удалить тест";
            this.DeleteTestButton.UseVisualStyleBackColor = true;
            this.DeleteTestButton.Click += new System.EventHandler(this.DeleteTestButton_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(824, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Назначить тест";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(824, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 52);
            this.button2.TabIndex = 6;
            this.button2.Text = "Результаты";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminOpportunities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteTestButton);
            this.Controls.Add(this.AddTestButton);
            this.Controls.Add(this.DeleteStudentsButton);
            this.Controls.Add(this.AddStudentButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminOpportunities";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminOpportunities";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button DeleteStudentsButton;
        private System.Windows.Forms.Button AddTestButton;
        private System.Windows.Forms.Button DeleteTestButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}