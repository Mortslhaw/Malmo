namespace MovieTheater
{
    partial class MainForm
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
            this.OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ReservationsListBox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NamnTextBox = new System.Windows.Forms.TextBox();
            this.PrisTextBox = new System.Windows.Forms.TextBox();
            this.ReserveraRadioButton = new System.Windows.Forms.RadioButton();
            this.AvslutaReservationRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LabelAntalTommaPlatser = new System.Windows.Forms.Label();
            this.LabelAntalReserverade = new System.Windows.Forms.Label();
            this.LabelTotaltAntalPlatser = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(57, 165);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(165, 30);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Boknings in data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.ReservationsListBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(310, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 325);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(172, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Pris";
            // 
            // ReservationsListBox
            // 
            this.ReservationsListBox.FormattingEnabled = true;
            this.ReservationsListBox.Location = new System.Drawing.Point(18, 63);
            this.ReservationsListBox.Name = "ReservationsListBox";
            this.ReservationsListBox.Size = new System.Drawing.Size(208, 251);
            this.ReservationsListBox.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Reservationer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Platser";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Namn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.NamnTextBox);
            this.groupBox2.Controls.Add(this.PrisTextBox);
            this.groupBox2.Controls.Add(this.ReserveraRadioButton);
            this.groupBox2.Controls.Add(this.AvslutaReservationRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(16, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 115);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(160, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Namn";
            // 
            // NamnTextBox
            // 
            this.NamnTextBox.Location = new System.Drawing.Point(6, 79);
            this.NamnTextBox.Name = "NamnTextBox";
            this.NamnTextBox.Size = new System.Drawing.Size(130, 20);
            this.NamnTextBox.TabIndex = 21;
            // 
            // PrisTextBox
            // 
            this.PrisTextBox.Location = new System.Drawing.Point(143, 79);
            this.PrisTextBox.Name = "PrisTextBox";
            this.PrisTextBox.Size = new System.Drawing.Size(100, 20);
            this.PrisTextBox.TabIndex = 22;
            // 
            // ReserveraRadioButton
            // 
            this.ReserveraRadioButton.AutoSize = true;
            this.ReserveraRadioButton.Location = new System.Drawing.Point(9, 34);
            this.ReserveraRadioButton.Name = "ReserveraRadioButton";
            this.ReserveraRadioButton.Size = new System.Drawing.Size(74, 17);
            this.ReserveraRadioButton.TabIndex = 19;
            this.ReserveraRadioButton.TabStop = true;
            this.ReserveraRadioButton.Text = "Reservera";
            this.ReserveraRadioButton.UseVisualStyleBackColor = true;
            this.ReserveraRadioButton.CheckedChanged += new System.EventHandler(this.ReserveraRadioButton_CheckedChanged);
            // 
            // AvslutaReservationRadioButton
            // 
            this.AvslutaReservationRadioButton.AutoSize = true;
            this.AvslutaReservationRadioButton.Location = new System.Drawing.Point(143, 34);
            this.AvslutaReservationRadioButton.Name = "AvslutaReservationRadioButton";
            this.AvslutaReservationRadioButton.Size = new System.Drawing.Size(114, 17);
            this.AvslutaReservationRadioButton.TabIndex = 20;
            this.AvslutaReservationRadioButton.TabStop = true;
            this.AvslutaReservationRadioButton.Text = "Avsluta Reseration";
            this.AvslutaReservationRadioButton.UseVisualStyleBackColor = true;
            this.AvslutaReservationRadioButton.CheckedChanged += new System.EventHandler(this.AvslutaReservationRadioButton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LabelAntalTommaPlatser);
            this.groupBox3.Controls.Add(this.LabelAntalReserverade);
            this.groupBox3.Controls.Add(this.LabelTotaltAntalPlatser);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(16, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 130);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // LabelAntalTommaPlatser
            // 
            this.LabelAntalTommaPlatser.AutoSize = true;
            this.LabelAntalTommaPlatser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelAntalTommaPlatser.Location = new System.Drawing.Point(211, 96);
            this.LabelAntalTommaPlatser.MinimumSize = new System.Drawing.Size(35, 0);
            this.LabelAntalTommaPlatser.Name = "LabelAntalTommaPlatser";
            this.LabelAntalTommaPlatser.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.LabelAntalTommaPlatser.Size = new System.Drawing.Size(35, 17);
            this.LabelAntalTommaPlatser.TabIndex = 26;
            // 
            // LabelAntalReserverade
            // 
            this.LabelAntalReserverade.AutoSize = true;
            this.LabelAntalReserverade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelAntalReserverade.Location = new System.Drawing.Point(212, 62);
            this.LabelAntalReserverade.MinimumSize = new System.Drawing.Size(35, 0);
            this.LabelAntalReserverade.Name = "LabelAntalReserverade";
            this.LabelAntalReserverade.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.LabelAntalReserverade.Size = new System.Drawing.Size(35, 17);
            this.LabelAntalReserverade.TabIndex = 25;
            // 
            // LabelTotaltAntalPlatser
            // 
            this.LabelTotaltAntalPlatser.AutoSize = true;
            this.LabelTotaltAntalPlatser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelTotaltAntalPlatser.Location = new System.Drawing.Point(212, 26);
            this.LabelTotaltAntalPlatser.MinimumSize = new System.Drawing.Size(35, 0);
            this.LabelTotaltAntalPlatser.Name = "LabelTotaltAntalPlatser";
            this.LabelTotaltAntalPlatser.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.LabelTotaltAntalPlatser.Size = new System.Drawing.Size(35, 17);
            this.LabelTotaltAntalPlatser.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Antal tomma platser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ut data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Antal reserverade platser";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Totalt antal platser";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 362);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OK);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox ReservationsListBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox NamnTextBox;
        private System.Windows.Forms.TextBox PrisTextBox;
        private System.Windows.Forms.RadioButton ReserveraRadioButton;
        private System.Windows.Forms.RadioButton AvslutaReservationRadioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LabelAntalTommaPlatser;
        private System.Windows.Forms.Label LabelAntalReserverade;
        private System.Windows.Forms.Label LabelTotaltAntalPlatser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

