namespace adatbazis_gyakorlas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.User_data = new System.Windows.Forms.TabPage();
            this.textAdatbazis_nev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.textPortName = new System.Windows.Forms.TextBox();
            this.textHostName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Alapadatok = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Beszuras = new System.Windows.Forms.TabPage();
            this.textGender = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textFirst_name = new System.Windows.Forms.TextBox();
            this.textBirth_month = new System.Windows.Forms.TextBox();
            this.textLast_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Frissites = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxbirth = new System.Windows.Forms.TextBox();
            this.textBoxgender = new System.Windows.Forms.TextBox();
            this.textfistname = new System.Windows.Forms.TextBox();
            this.textLastname = new System.Windows.Forms.TextBox();
            this.textBoxage = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.User_data.SuspendLayout();
            this.Alapadatok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Beszuras.SuspendLayout();
            this.Frissites.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.User_data);
            this.tabControl1.Controls.Add(this.Alapadatok);
            this.tabControl1.Controls.Add(this.Beszuras);
            this.tabControl1.Controls.Add(this.Frissites);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // User_data
            // 
            this.User_data.Controls.Add(this.textAdatbazis_nev);
            this.User_data.Controls.Add(this.label5);
            this.User_data.Controls.Add(this.btnUpdate);
            this.User_data.Controls.Add(this.textPassword);
            this.User_data.Controls.Add(this.label4);
            this.User_data.Controls.Add(this.textUserName);
            this.User_data.Controls.Add(this.textPortName);
            this.User_data.Controls.Add(this.textHostName);
            this.User_data.Controls.Add(this.label3);
            this.User_data.Controls.Add(this.label2);
            this.User_data.Controls.Add(this.label1);
            this.User_data.Location = new System.Drawing.Point(4, 25);
            this.User_data.Name = "User_data";
            this.User_data.Padding = new System.Windows.Forms.Padding(3);
            this.User_data.Size = new System.Drawing.Size(792, 421);
            this.User_data.TabIndex = 0;
            this.User_data.Text = "User_data";
            this.User_data.UseVisualStyleBackColor = true;
            // 
            // textAdatbazis_nev
            // 
            this.textAdatbazis_nev.Location = new System.Drawing.Point(150, 202);
            this.textAdatbazis_nev.Name = "textAdatbazis_nev";
            this.textAdatbazis_nev.Size = new System.Drawing.Size(123, 22);
            this.textAdatbazis_nev.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Adatbázis_név";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(150, 257);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 32);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Frissités";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(150, 156);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(123, 22);
            this.textPassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jelszo:";
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(150, 113);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(123, 22);
            this.textUserName.TabIndex = 3;
            this.textUserName.TextChanged += new System.EventHandler(this.textUserName_TextChanged);
            // 
            // textPortName
            // 
            this.textPortName.Location = new System.Drawing.Point(150, 78);
            this.textPortName.Name = "textPortName";
            this.textPortName.Size = new System.Drawing.Size(123, 22);
            this.textPortName.TabIndex = 3;
            this.textPortName.TextChanged += new System.EventHandler(this.textPortName_TextChanged);
            // 
            // textHostName
            // 
            this.textHostName.Location = new System.Drawing.Point(150, 38);
            this.textHostName.Name = "textHostName";
            this.textHostName.Size = new System.Drawing.Size(123, 22);
            this.textHostName.TabIndex = 3;
            this.textHostName.TextChanged += new System.EventHandler(this.textHostName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "FelhasználóNév:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gép név (host):";
            // 
            // Alapadatok
            // 
            this.Alapadatok.Controls.Add(this.dataGridView1);
            this.Alapadatok.Location = new System.Drawing.Point(4, 25);
            this.Alapadatok.Name = "Alapadatok";
            this.Alapadatok.Padding = new System.Windows.Forms.Padding(3);
            this.Alapadatok.Size = new System.Drawing.Size(792, 421);
            this.Alapadatok.TabIndex = 1;
            this.Alapadatok.Text = "Alapadatok";
            this.Alapadatok.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(778, 386);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Beszuras
            // 
            this.Beszuras.Controls.Add(this.textGender);
            this.Beszuras.Controls.Add(this.textAge);
            this.Beszuras.Controls.Add(this.button1);
            this.Beszuras.Controls.Add(this.textFirst_name);
            this.Beszuras.Controls.Add(this.textBirth_month);
            this.Beszuras.Controls.Add(this.textLast_name);
            this.Beszuras.Controls.Add(this.label10);
            this.Beszuras.Controls.Add(this.label9);
            this.Beszuras.Controls.Add(this.label8);
            this.Beszuras.Controls.Add(this.label7);
            this.Beszuras.Controls.Add(this.label6);
            this.Beszuras.Location = new System.Drawing.Point(4, 25);
            this.Beszuras.Name = "Beszuras";
            this.Beszuras.Padding = new System.Windows.Forms.Padding(3);
            this.Beszuras.Size = new System.Drawing.Size(792, 421);
            this.Beszuras.TabIndex = 2;
            this.Beszuras.Text = "Beszuras";
            this.Beszuras.UseVisualStyleBackColor = true;
            // 
            // textGender
            // 
            this.textGender.Location = new System.Drawing.Point(117, 252);
            this.textGender.Name = "textGender";
            this.textGender.Size = new System.Drawing.Size(124, 22);
            this.textGender.TabIndex = 3;
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(127, 208);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(124, 22);
            this.textAge.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textFirst_name
            // 
            this.textFirst_name.Location = new System.Drawing.Point(127, 48);
            this.textFirst_name.Name = "textFirst_name";
            this.textFirst_name.Size = new System.Drawing.Size(138, 22);
            this.textFirst_name.TabIndex = 1;
            // 
            // textBirth_month
            // 
            this.textBirth_month.Location = new System.Drawing.Point(127, 157);
            this.textBirth_month.Name = "textBirth_month";
            this.textBirth_month.Size = new System.Drawing.Size(138, 22);
            this.textBirth_month.TabIndex = 1;
            // 
            // textLast_name
            // 
            this.textLast_name.Location = new System.Drawing.Point(127, 105);
            this.textLast_name.Name = "textLast_name";
            this.textLast_name.Size = new System.Drawing.Size(138, 22);
            this.textLast_name.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Gender";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Age";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "birth_month";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "first_name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "last_name";
            // 
            // Frissites
            // 
            this.Frissites.Controls.Add(this.button3);
            this.Frissites.Controls.Add(this.button2);
            this.Frissites.Controls.Add(this.textBoxbirth);
            this.Frissites.Controls.Add(this.textBoxgender);
            this.Frissites.Controls.Add(this.textfistname);
            this.Frissites.Controls.Add(this.textLastname);
            this.Frissites.Controls.Add(this.textBoxage);
            this.Frissites.Controls.Add(this.textBox1);
            this.Frissites.Controls.Add(this.label16);
            this.Frissites.Controls.Add(this.label15);
            this.Frissites.Controls.Add(this.label13);
            this.Frissites.Controls.Add(this.label14);
            this.Frissites.Controls.Add(this.label12);
            this.Frissites.Controls.Add(this.label11);
            this.Frissites.Location = new System.Drawing.Point(4, 25);
            this.Frissites.Name = "Frissites";
            this.Frissites.Padding = new System.Windows.Forms.Padding(3);
            this.Frissites.Size = new System.Drawing.Size(792, 421);
            this.Frissites.TabIndex = 3;
            this.Frissites.Text = "Frissites";
            this.Frissites.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(570, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 24);
            this.button3.TabIndex = 3;
            this.button3.Text = "frissítés";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(452, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "keresés";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBoxbirth
            // 
            this.textBoxbirth.Location = new System.Drawing.Point(616, 169);
            this.textBoxbirth.Name = "textBoxbirth";
            this.textBoxbirth.Size = new System.Drawing.Size(101, 22);
            this.textBoxbirth.TabIndex = 2;
            // 
            // textBoxgender
            // 
            this.textBoxgender.Location = new System.Drawing.Point(478, 169);
            this.textBoxgender.Name = "textBoxgender";
            this.textBoxgender.Size = new System.Drawing.Size(101, 22);
            this.textBoxgender.TabIndex = 2;
            // 
            // textfistname
            // 
            this.textfistname.Location = new System.Drawing.Point(60, 169);
            this.textfistname.Name = "textfistname";
            this.textfistname.Size = new System.Drawing.Size(101, 22);
            this.textfistname.TabIndex = 2;
            // 
            // textLastname
            // 
            this.textLastname.Location = new System.Drawing.Point(196, 169);
            this.textLastname.Name = "textLastname";
            this.textLastname.Size = new System.Drawing.Size(101, 22);
            this.textLastname.TabIndex = 2;
            // 
            // textBoxage
            // 
            this.textBoxage.Location = new System.Drawing.Point(339, 169);
            this.textBoxage.Name = "textBoxage";
            this.textBoxage.Size = new System.Drawing.Size(101, 22);
            this.textBoxage.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(646, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "birth_date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(496, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "gender";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(349, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "age";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(86, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "fist_name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(208, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "last_name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(77, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "fist_name";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(45, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 31);
            this.button4.TabIndex = 0;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.User_data.ResumeLayout(false);
            this.User_data.PerformLayout();
            this.Alapadatok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Beszuras.ResumeLayout(false);
            this.Beszuras.PerformLayout();
            this.Frissites.ResumeLayout(false);
            this.Frissites.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage User_data;
        private System.Windows.Forms.TabPage Alapadatok;
        private System.Windows.Forms.TabPage Beszuras;
        private System.Windows.Forms.TabPage Frissites;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.TextBox textPortName;
        private System.Windows.Forms.TextBox textHostName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textAdatbazis_nev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textFirst_name;
        private System.Windows.Forms.TextBox textBirth_month;
        private System.Windows.Forms.TextBox textLast_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textGender;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxbirth;
        private System.Windows.Forms.TextBox textBoxgender;
        private System.Windows.Forms.TextBox textfistname;
        private System.Windows.Forms.TextBox textLastname;
        private System.Windows.Forms.TextBox textBoxage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button4;
    }
}

