namespace Assignement5
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.DeleteAllBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.RegistredRecordsLabel = new System.Windows.Forms.Label();
            this.FirstNameTxt = new System.Windows.Forms.TextBox();
            this.LastNameTxt = new System.Windows.Forms.TextBox();
            this.StreetTxt = new System.Windows.Forms.TextBox();
            this.CityTxt = new System.Windows.Forms.TextBox();
            this.ZipTxt = new System.Windows.Forms.TextBox();
            this.CountryCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LastNameTxt);
            this.groupBox1.Controls.Add(this.FirstNameTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CountryCombo);
            this.groupBox2.Controls.Add(this.ZipTxt);
            this.groupBox2.Controls.Add(this.CityTxt);
            this.groupBox2.Controls.Add(this.StreetTxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 151);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Street";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Zip Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Country";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(433, 46);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 36);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Location = new System.Drawing.Point(433, 88);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(75, 36);
            this.ChangeBtn.TabIndex = 3;
            this.ChangeBtn.Text = "Change";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(433, 130);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 36);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 277);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(649, 225);
            this.listBox1.TabIndex = 5;
            // 
            // DeleteAllBtn
            // 
            this.DeleteAllBtn.Location = new System.Drawing.Point(433, 171);
            this.DeleteAllBtn.Name = "DeleteAllBtn";
            this.DeleteAllBtn.Size = new System.Drawing.Size(75, 36);
            this.DeleteAllBtn.TabIndex = 6;
            this.DeleteAllBtn.Text = "Delete all";
            this.DeleteAllBtn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(433, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "No of registered records";
            // 
            // RegistredRecordsLabel
            // 
            this.RegistredRecordsLabel.AutoSize = true;
            this.RegistredRecordsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RegistredRecordsLabel.Location = new System.Drawing.Point(588, 258);
            this.RegistredRecordsLabel.Name = "RegistredRecordsLabel";
            this.RegistredRecordsLabel.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.RegistredRecordsLabel.Size = new System.Drawing.Size(32, 15);
            this.RegistredRecordsLabel.TabIndex = 8;
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.Location = new System.Drawing.Point(144, 18);
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(187, 20);
            this.FirstNameTxt.TabIndex = 2;
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.Location = new System.Drawing.Point(144, 44);
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.Size = new System.Drawing.Size(187, 20);
            this.LastNameTxt.TabIndex = 3;
            // 
            // StreetTxt
            // 
            this.StreetTxt.Location = new System.Drawing.Point(144, 30);
            this.StreetTxt.Name = "StreetTxt";
            this.StreetTxt.Size = new System.Drawing.Size(187, 20);
            this.StreetTxt.TabIndex = 5;
            // 
            // CityTxt
            // 
            this.CityTxt.Location = new System.Drawing.Point(144, 56);
            this.CityTxt.Name = "CityTxt";
            this.CityTxt.Size = new System.Drawing.Size(187, 20);
            this.CityTxt.TabIndex = 6;
            // 
            // ZipTxt
            // 
            this.ZipTxt.Location = new System.Drawing.Point(144, 84);
            this.ZipTxt.Name = "ZipTxt";
            this.ZipTxt.Size = new System.Drawing.Size(187, 20);
            this.ZipTxt.TabIndex = 7;
            // 
            // CountryCombo
            // 
            this.CountryCombo.FormattingEnabled = true;
            this.CountryCombo.Location = new System.Drawing.Point(144, 110);
            this.CountryCombo.Name = "CountryCombo";
            this.CountryCombo.Size = new System.Drawing.Size(187, 21);
            this.CountryCombo.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 506);
            this.Controls.Add(this.RegistredRecordsLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DeleteAllBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox LastNameTxt;
        private System.Windows.Forms.TextBox FirstNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CountryCombo;
        private System.Windows.Forms.TextBox ZipTxt;
        private System.Windows.Forms.TextBox CityTxt;
        private System.Windows.Forms.TextBox StreetTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button DeleteAllBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label RegistredRecordsLabel;
    }
}

