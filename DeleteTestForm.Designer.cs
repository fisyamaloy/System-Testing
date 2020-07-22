namespace Проект.Рестарт
{
    partial class DeleteTestForm
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
            this.NameTestsBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DelTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTestsBox
            // 
            this.NameTestsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameTestsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTestsBox.FormattingEnabled = true;
            this.NameTestsBox.Location = new System.Drawing.Point(58, 155);
            this.NameTestsBox.Name = "NameTestsBox";
            this.NameTestsBox.Size = new System.Drawing.Size(254, 37);
            this.NameTestsBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(52, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Тест:";
            // 
            // DelTest
            // 
            this.DelTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelTest.Location = new System.Drawing.Point(58, 229);
            this.DelTest.Name = "DelTest";
            this.DelTest.Size = new System.Drawing.Size(173, 45);
            this.DelTest.TabIndex = 20;
            this.DelTest.Text = "Удалить";
            this.DelTest.UseVisualStyleBackColor = true;
            this.DelTest.Click += new System.EventHandler(this.DelTest_Click);
            // 
            // DeleteTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(426, 351);
            this.Controls.Add(this.DelTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTestsBox);
            this.Name = "DeleteTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteTestForm";
            this.Load += new System.EventHandler(this.DeleteTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NameTestsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DelTest;
    }
}