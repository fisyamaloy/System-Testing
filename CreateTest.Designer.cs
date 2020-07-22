namespace Проект.Рестарт
{
    partial class CreateTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.SelectTest = new System.Windows.Forms.Button();
            this.ToDownload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(103, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите файл с тестом( .txt)";
            // 
            // SelectTest
            // 
            this.SelectTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectTest.Location = new System.Drawing.Point(147, 86);
            this.SelectTest.Name = "SelectTest";
            this.SelectTest.Size = new System.Drawing.Size(284, 52);
            this.SelectTest.TabIndex = 9;
            this.SelectTest.Text = "Выбрать";
            this.SelectTest.UseVisualStyleBackColor = true;
            this.SelectTest.Click += new System.EventHandler(this.SelectTest_Click);
            // 
            // ToDownload
            // 
            this.ToDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToDownload.Location = new System.Drawing.Point(147, 144);
            this.ToDownload.Name = "ToDownload";
            this.ToDownload.Size = new System.Drawing.Size(284, 52);
            this.ToDownload.TabIndex = 10;
            this.ToDownload.Text = "Загрузить";
            this.ToDownload.UseVisualStyleBackColor = true;
            this.ToDownload.Click += new System.EventHandler(this.ToDownload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(296, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 11;
            // 
            // CreateTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(580, 295);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ToDownload);
            this.Controls.Add(this.SelectTest);
            this.Controls.Add(this.label1);
            this.Name = "CreateTest";
            this.Text = "CreateTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectTest;
        private System.Windows.Forms.Button ToDownload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
    }
}