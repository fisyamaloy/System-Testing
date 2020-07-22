namespace Проект.Рестарт
{
    partial class visibility
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
            this.label2 = new System.Windows.Forms.Label();
            this.NameTestsBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClassesCombBox = new System.Windows.Forms.ComboBox();
            this.isAssigned = new System.Windows.Forms.RadioButton();
            this.isNotAssigned = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "Тест:";
            // 
            // NameTestsBox
            // 
            this.NameTestsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameTestsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTestsBox.FormattingEnabled = true;
            this.NameTestsBox.Location = new System.Drawing.Point(179, 133);
            this.NameTestsBox.Name = "NameTestsBox";
            this.NameTestsBox.Size = new System.Drawing.Size(254, 37);
            this.NameTestsBox.TabIndex = 21;
            this.NameTestsBox.SelectedIndexChanged += new System.EventHandler(this.NameTestsBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Класс:";
            // 
            // ClassesCombBox
            // 
            this.ClassesCombBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassesCombBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassesCombBox.FormattingEnabled = true;
            this.ClassesCombBox.Location = new System.Drawing.Point(179, 70);
            this.ClassesCombBox.Name = "ClassesCombBox";
            this.ClassesCombBox.Size = new System.Drawing.Size(254, 37);
            this.ClassesCombBox.TabIndex = 23;
            this.ClassesCombBox.SelectedIndexChanged += new System.EventHandler(this.ClassesCombBox_SelectedIndexChanged);
            // 
            // isAssigned
            // 
            this.isAssigned.AutoSize = true;
            this.isAssigned.Location = new System.Drawing.Point(51, 209);
            this.isAssigned.Name = "isAssigned";
            this.isAssigned.Size = new System.Drawing.Size(121, 29);
            this.isAssigned.TabIndex = 25;
            this.isAssigned.TabStop = true;
            this.isAssigned.Text = "Назначен";
            this.isAssigned.UseVisualStyleBackColor = true;
            this.isAssigned.CheckedChanged += new System.EventHandler(this.isAssigned_CheckedChanged);
            // 
            // isNotAssigned
            // 
            this.isNotAssigned.AutoSize = true;
            this.isNotAssigned.Location = new System.Drawing.Point(257, 209);
            this.isNotAssigned.Name = "isNotAssigned";
            this.isNotAssigned.Size = new System.Drawing.Size(148, 29);
            this.isNotAssigned.TabIndex = 26;
            this.isNotAssigned.TabStop = true;
            this.isNotAssigned.Text = "Не назначен";
            this.isNotAssigned.UseVisualStyleBackColor = true;
            this.isNotAssigned.CheckedChanged += new System.EventHandler(this.isNotAssigned_CheckedChanged);
            // 
            // visibility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(482, 328);
            this.Controls.Add(this.isNotAssigned);
            this.Controls.Add(this.isAssigned);
            this.Controls.Add(this.ClassesCombBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTestsBox);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "visibility";
            this.Text = "visibility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NameTestsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ClassesCombBox;
        private System.Windows.Forms.RadioButton isAssigned;
        private System.Windows.Forms.RadioButton isNotAssigned;
    }
}