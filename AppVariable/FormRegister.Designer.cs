namespace AppVariable
{
    partial class FormRegister
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.nu_age = new System.Windows.Forms.NumericUpDown();
            this.pk_dob = new System.Windows.Forms.DateTimePicker();
            this.com_level = new System.Windows.Forms.ComboBox();
            this.ra_A = new System.Windows.Forms.RadioButton();
            this.ra_O = new System.Windows.Forms.RadioButton();
            this.ra_B = new System.Windows.Forms.RadioButton();
            this.ra_AB = new System.Windows.Forms.RadioButton();
            this.b_regis = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.la_name = new System.Windows.Forms.Label();
            this.la_blood = new System.Windows.Forms.Label();
            this.la_level = new System.Windows.Forms.Label();
            this.la_dob = new System.Windows.Forms.Label();
            this.la_phone = new System.Windows.Forms.Label();
            this.la_age = new System.Windows.Forms.Label();
            this.la_email = new System.Windows.Forms.Label();
            this.la_surname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nu_age)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(346, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "สมัครสมาชิก";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cyan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(107, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cyan;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(98, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "สกุล";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Cyan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(84, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Cyan;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(100, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "อายุ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Cyan;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(5, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "หมายเลขโทรศัพท์";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Cyan;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(27, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "วัน/เดือน/ปีเกิด";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Cyan;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(70, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "ระดับชั้น";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Cyan;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(71, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "หมู่เลือด";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_name.Location = new System.Drawing.Point(141, 52);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(270, 26);
            this.txt_name.TabIndex = 0;
            // 
            // txt_surname
            // 
            this.txt_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_surname.Location = new System.Drawing.Point(141, 98);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(270, 26);
            this.txt_surname.TabIndex = 1;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_email.Location = new System.Drawing.Point(141, 139);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(270, 26);
            this.txt_email.TabIndex = 2;
            this.txt_email.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_phone.Location = new System.Drawing.Point(141, 184);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(270, 26);
            this.txt_phone.TabIndex = 3;
            // 
            // nu_age
            // 
            this.nu_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nu_age.Location = new System.Drawing.Point(141, 233);
            this.nu_age.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nu_age.Name = "nu_age";
            this.nu_age.Size = new System.Drawing.Size(120, 26);
            this.nu_age.TabIndex = 4;
            this.nu_age.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nu_age.ValueChanged += new System.EventHandler(this.nu_age_ValueChanged);
            // 
            // pk_dob
            // 
            this.pk_dob.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pk_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pk_dob.Location = new System.Drawing.Point(141, 281);
            this.pk_dob.Name = "pk_dob";
            this.pk_dob.Size = new System.Drawing.Size(270, 26);
            this.pk_dob.TabIndex = 5;
            this.pk_dob.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // com_level
            // 
            this.com_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.com_level.FormattingEnabled = true;
            this.com_level.Items.AddRange(new object[] {
            "ปวช.",
            "ปวส.",
            "ป.ตรี."});
            this.com_level.Location = new System.Drawing.Point(140, 323);
            this.com_level.Name = "com_level";
            this.com_level.Size = new System.Drawing.Size(121, 28);
            this.com_level.TabIndex = 6;
            // 
            // ra_A
            // 
            this.ra_A.AutoSize = true;
            this.ra_A.Location = new System.Drawing.Point(147, 367);
            this.ra_A.Name = "ra_A";
            this.ra_A.Size = new System.Drawing.Size(37, 20);
            this.ra_A.TabIndex = 8;
            this.ra_A.TabStop = true;
            this.ra_A.Text = "A";
            this.ra_A.UseVisualStyleBackColor = true;
            this.ra_A.CheckedChanged += new System.EventHandler(this.ra_A_CheckedChanged);
            // 
            // ra_O
            // 
            this.ra_O.AutoSize = true;
            this.ra_O.Location = new System.Drawing.Point(147, 393);
            this.ra_O.Name = "ra_O";
            this.ra_O.Size = new System.Drawing.Size(38, 20);
            this.ra_O.TabIndex = 9;
            this.ra_O.TabStop = true;
            this.ra_O.Text = "O";
            this.ra_O.UseVisualStyleBackColor = true;
            this.ra_O.CheckedChanged += new System.EventHandler(this.ra_O_CheckedChanged);
            // 
            // ra_B
            // 
            this.ra_B.AutoSize = true;
            this.ra_B.Location = new System.Drawing.Point(190, 367);
            this.ra_B.Name = "ra_B";
            this.ra_B.Size = new System.Drawing.Size(37, 20);
            this.ra_B.TabIndex = 8;
            this.ra_B.TabStop = true;
            this.ra_B.Text = "B";
            this.ra_B.UseVisualStyleBackColor = true;
            this.ra_B.CheckedChanged += new System.EventHandler(this.ra_B_CheckedChanged);
            // 
            // ra_AB
            // 
            this.ra_AB.AutoSize = true;
            this.ra_AB.Location = new System.Drawing.Point(190, 393);
            this.ra_AB.Name = "ra_AB";
            this.ra_AB.Size = new System.Drawing.Size(46, 20);
            this.ra_AB.TabIndex = 10;
            this.ra_AB.TabStop = true;
            this.ra_AB.Text = "AB";
            this.ra_AB.UseVisualStyleBackColor = true;
            this.ra_AB.CheckedChanged += new System.EventHandler(this.ra_AB_CheckedChanged);
            // 
            // b_regis
            // 
            this.b_regis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b_regis.Location = new System.Drawing.Point(283, 368);
            this.b_regis.Name = "b_regis";
            this.b_regis.Size = new System.Drawing.Size(90, 46);
            this.b_regis.TabIndex = 7;
            this.b_regis.Text = "สมัคร";
            this.b_regis.UseVisualStyleBackColor = true;
            this.b_regis.Click += new System.EventHandler(this.b_regis_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.la_blood);
            this.groupBox1.Controls.Add(this.la_name);
            this.groupBox1.Controls.Add(this.la_level);
            this.groupBox1.Controls.Add(this.la_phone);
            this.groupBox1.Controls.Add(this.la_dob);
            this.groupBox1.Controls.Add(this.la_surname);
            this.groupBox1.Controls.Add(this.la_email);
            this.groupBox1.Controls.Add(this.la_age);
            this.groupBox1.Location = new System.Drawing.Point(417, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 386);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ผลลัพธ์";
            // 
            // la_name
            // 
            this.la_name.AutoSize = true;
            this.la_name.BackColor = System.Drawing.Color.Cyan;
            this.la_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.la_name.Location = new System.Drawing.Point(6, 22);
            this.la_name.Name = "la_name";
            this.la_name.Size = new System.Drawing.Size(28, 20);
            this.la_name.TabIndex = 2;
            this.la_name.Text = "ชื่อ";
            // 
            // la_blood
            // 
            this.la_blood.AutoSize = true;
            this.la_blood.BackColor = System.Drawing.Color.Cyan;
            this.la_blood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.la_blood.Location = new System.Drawing.Point(6, 324);
            this.la_blood.Name = "la_blood";
            this.la_blood.Size = new System.Drawing.Size(64, 20);
            this.la_blood.TabIndex = 18;
            this.la_blood.Text = "หมู่เลือด";
            // 
            // la_level
            // 
            this.la_level.AutoSize = true;
            this.la_level.BackColor = System.Drawing.Color.Cyan;
            this.la_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.la_level.Location = new System.Drawing.Point(6, 281);
            this.la_level.Name = "la_level";
            this.la_level.Size = new System.Drawing.Size(65, 20);
            this.la_level.TabIndex = 17;
            this.la_level.Text = "ระดับชั้น";
            // 
            // la_dob
            // 
            this.la_dob.AutoSize = true;
            this.la_dob.BackColor = System.Drawing.Color.Cyan;
            this.la_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.la_dob.Location = new System.Drawing.Point(6, 240);
            this.la_dob.Name = "la_dob";
            this.la_dob.Size = new System.Drawing.Size(108, 20);
            this.la_dob.TabIndex = 16;
            this.la_dob.Text = "วัน/เดือน/ปีเกิด";
            // 
            // la_phone
            // 
            this.la_phone.AutoSize = true;
            this.la_phone.BackColor = System.Drawing.Color.Cyan;
            this.la_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.la_phone.Location = new System.Drawing.Point(6, 145);
            this.la_phone.Name = "la_phone";
            this.la_phone.Size = new System.Drawing.Size(130, 20);
            this.la_phone.TabIndex = 15;
            this.la_phone.Text = "หมายเลขโทรศัพท์";
            // 
            // la_age
            // 
            this.la_age.AutoSize = true;
            this.la_age.BackColor = System.Drawing.Color.Cyan;
            this.la_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.la_age.Location = new System.Drawing.Point(6, 193);
            this.la_age.Name = "la_age";
            this.la_age.Size = new System.Drawing.Size(35, 20);
            this.la_age.TabIndex = 14;
            this.la_age.Text = "อายุ";
            // 
            // la_email
            // 
            this.la_email.AutoSize = true;
            this.la_email.BackColor = System.Drawing.Color.Cyan;
            this.la_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.la_email.Location = new System.Drawing.Point(6, 101);
            this.la_email.Name = "la_email";
            this.la_email.Size = new System.Drawing.Size(51, 20);
            this.la_email.TabIndex = 13;
            this.la_email.Text = "Email";
            // 
            // la_surname
            // 
            this.la_surname.AutoSize = true;
            this.la_surname.BackColor = System.Drawing.Color.Cyan;
            this.la_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.la_surname.Location = new System.Drawing.Point(6, 59);
            this.la_surname.Name = "la_surname";
            this.la_surname.Size = new System.Drawing.Size(37, 20);
            this.la_surname.TabIndex = 12;
            this.la_surname.Text = "สกุล";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(772, 443);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.b_regis);
            this.Controls.Add(this.ra_AB);
            this.Controls.Add(this.ra_B);
            this.Controls.Add(this.ra_O);
            this.Controls.Add(this.ra_A);
            this.Controls.Add(this.com_level);
            this.Controls.Add(this.pk_dob);
            this.Controls.Add(this.nu_age);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            ((System.ComponentModel.ISupportInitialize)(this.nu_age)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.NumericUpDown nu_age;
        private System.Windows.Forms.DateTimePicker pk_dob;
        private System.Windows.Forms.ComboBox com_level;
        private System.Windows.Forms.RadioButton ra_A;
        private System.Windows.Forms.RadioButton ra_O;
        private System.Windows.Forms.RadioButton ra_B;
        private System.Windows.Forms.RadioButton ra_AB;
        private System.Windows.Forms.Button b_regis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label la_blood;
        private System.Windows.Forms.Label la_name;
        private System.Windows.Forms.Label la_level;
        private System.Windows.Forms.Label la_phone;
        private System.Windows.Forms.Label la_dob;
        private System.Windows.Forms.Label la_surname;
        private System.Windows.Forms.Label la_email;
        private System.Windows.Forms.Label la_age;
    }
}