namespace attendance_system
{
    partial class studentView
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnshowRecord1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SubName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnshowstud = new System.Windows.Forms.Button();
            this.dateTimePickeraddstu = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtaddsturoll = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtaddstuname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtaddstupass = new System.Windows.Forms.TextBox();
            this.txtaddstuemail = new System.Windows.Forms.TextBox();
            this.txtaddstucont = new System.Windows.Forms.TextBox();
            this.txtaddstuaddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBoxleave = new System.Windows.Forms.ComboBox();
            this.dateTimePickerleave = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewleave = new System.Windows.Forms.DataGridView();
            this.btnleave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtreason = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewleave)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 41);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(594, 415);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnshowRecord1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.SubName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(586, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Attendance";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(516, 251);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnshowRecord1
            // 
            this.btnshowRecord1.BackColor = System.Drawing.Color.SteelBlue;
            this.btnshowRecord1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnshowRecord1.Location = new System.Drawing.Point(477, 35);
            this.btnshowRecord1.Name = "btnshowRecord1";
            this.btnshowRecord1.Size = new System.Drawing.Size(75, 23);
            this.btnshowRecord1.TabIndex = 10;
            this.btnshowRecord1.Text = "show";
            this.btnshowRecord1.UseVisualStyleBackColor = false;
            this.btnshowRecord1.Click += new System.EventHandler(this.btnshowRecord1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "date :";
            // 
            // SubName
            // 
            this.SubName.FormattingEnabled = true;
            this.SubName.Items.AddRange(new object[] {
            "C_Language",
            "Cpp_Language",
            "Java_Programming",
            "vb_net"});
            this.SubName.Location = new System.Drawing.Point(77, 35);
            this.SubName.Name = "SubName";
            this.SubName.Size = new System.Drawing.Size(121, 21);
            this.SubName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "subject : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(260, 35);
            this.dateTimePicker1.MaxDate = new System.DateTime(2021, 7, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2018, 9, 9, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2021, 7, 1, 0, 0, 0, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btnshowstud);
            this.tabPage2.Controls.Add(this.dateTimePickeraddstu);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtaddsturoll);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtaddstuname);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtaddstupass);
            this.tabPage2.Controls.Add(this.txtaddstuemail);
            this.tabPage2.Controls.Add(this.txtaddstucont);
            this.tabPage2.Controls.Add(this.txtaddstuaddress);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(586, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update Profile";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(349, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 32);
            this.button3.TabIndex = 30;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(219, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 32);
            this.button2.TabIndex = 30;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnshowstud
            // 
            this.btnshowstud.BackColor = System.Drawing.Color.SteelBlue;
            this.btnshowstud.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnshowstud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowstud.Location = new System.Drawing.Point(85, 232);
            this.btnshowstud.Name = "btnshowstud";
            this.btnshowstud.Size = new System.Drawing.Size(83, 32);
            this.btnshowstud.TabIndex = 30;
            this.btnshowstud.Text = "View";
            this.btnshowstud.UseVisualStyleBackColor = false;
            this.btnshowstud.Click += new System.EventHandler(this.btnshowstud_Click);
            // 
            // dateTimePickeraddstu
            // 
            this.dateTimePickeraddstu.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickeraddstu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickeraddstu.Location = new System.Drawing.Point(111, 166);
            this.dateTimePickeraddstu.MaxDate = new System.DateTime(2021, 7, 1, 0, 0, 0, 0);
            this.dateTimePickeraddstu.Name = "dateTimePickeraddstu";
            this.dateTimePickeraddstu.Size = new System.Drawing.Size(142, 20);
            this.dateTimePickeraddstu.TabIndex = 29;
            this.dateTimePickeraddstu.Value = new System.DateTime(2021, 7, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "DOB :";
            // 
            // txtaddsturoll
            // 
            this.txtaddsturoll.Location = new System.Drawing.Point(112, 29);
            this.txtaddsturoll.Name = "txtaddsturoll";
            this.txtaddsturoll.ReadOnly = true;
            this.txtaddsturoll.Size = new System.Drawing.Size(141, 20);
            this.txtaddsturoll.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Roll No. :";
            // 
            // txtaddstuname
            // 
            this.txtaddstuname.Location = new System.Drawing.Point(111, 73);
            this.txtaddstuname.Name = "txtaddstuname";
            this.txtaddstuname.Size = new System.Drawing.Size(142, 20);
            this.txtaddstuname.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Name :";
            // 
            // txtaddstupass
            // 
            this.txtaddstupass.Location = new System.Drawing.Point(369, 119);
            this.txtaddstupass.Name = "txtaddstupass";
            this.txtaddstupass.Size = new System.Drawing.Size(139, 20);
            this.txtaddstupass.TabIndex = 23;
            // 
            // txtaddstuemail
            // 
            this.txtaddstuemail.Location = new System.Drawing.Point(370, 70);
            this.txtaddstuemail.Name = "txtaddstuemail";
            this.txtaddstuemail.Size = new System.Drawing.Size(138, 20);
            this.txtaddstuemail.TabIndex = 22;
            // 
            // txtaddstucont
            // 
            this.txtaddstucont.Location = new System.Drawing.Point(370, 29);
            this.txtaddstucont.Name = "txtaddstucont";
            this.txtaddstucont.Size = new System.Drawing.Size(138, 20);
            this.txtaddstucont.TabIndex = 21;
            // 
            // txtaddstuaddress
            // 
            this.txtaddstuaddress.Location = new System.Drawing.Point(111, 120);
            this.txtaddstuaddress.Name = "txtaddstuaddress";
            this.txtaddstuaddress.Size = new System.Drawing.Size(142, 20);
            this.txtaddstuaddress.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Password :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Email :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Contact :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "address :";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage3.Controls.Add(this.comboBoxleave);
            this.tabPage3.Controls.Add(this.dateTimePickerleave);
            this.tabPage3.Controls.Add(this.dataGridViewleave);
            this.tabPage3.Controls.Add(this.btnleave);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txtreason);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(586, 389);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "apply leave";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // comboBoxleave
            // 
            this.comboBoxleave.FormattingEnabled = true;
            this.comboBoxleave.Items.AddRange(new object[] {
            "C_Language",
            "Cpp_Language",
            "Java_Programming",
            "vb_net"});
            this.comboBoxleave.Location = new System.Drawing.Point(100, 49);
            this.comboBoxleave.Name = "comboBoxleave";
            this.comboBoxleave.Size = new System.Drawing.Size(151, 21);
            this.comboBoxleave.TabIndex = 5;
            // 
            // dateTimePickerleave
            // 
            this.dateTimePickerleave.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerleave.Location = new System.Drawing.Point(88, 110);
            this.dateTimePickerleave.Name = "dateTimePickerleave";
            this.dateTimePickerleave.Size = new System.Drawing.Size(163, 20);
            this.dateTimePickerleave.TabIndex = 4;
            // 
            // dataGridViewleave
            // 
            this.dataGridViewleave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewleave.Location = new System.Drawing.Point(9, 235);
            this.dataGridViewleave.Name = "dataGridViewleave";
            this.dataGridViewleave.Size = new System.Drawing.Size(568, 136);
            this.dataGridViewleave.TabIndex = 3;
            // 
            // btnleave
            // 
            this.btnleave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnleave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnleave.Location = new System.Drawing.Point(215, 176);
            this.btnleave.Name = "btnleave";
            this.btnleave.Size = new System.Drawing.Size(117, 30);
            this.btnleave.TabIndex = 2;
            this.btnleave.Text = "apply";
            this.btnleave.UseVisualStyleBackColor = false;
            this.btnleave.Click += new System.EventHandler(this.btnleave_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Date";
            // 
            // txtreason
            // 
            this.txtreason.Location = new System.Drawing.Point(327, 49);
            this.txtreason.Multiline = true;
            this.txtreason.Name = "txtreason";
            this.txtreason.Size = new System.Drawing.Size(250, 81);
            this.txtreason.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(277, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Reason";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Subject Name";
            // 
            // lblname
            // 
            this.lblname.BackColor = System.Drawing.Color.SteelBlue;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(0, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(590, 38);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "name";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // studentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 446);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.tabControl1);
            this.Name = "studentView";
            this.Text = "Student Portal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.studentView_FormClosed);
            this.Load += new System.EventHandler(this.studentView_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewleave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnshowRecord1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SubName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtaddstupass;
        private System.Windows.Forms.TextBox txtaddstuemail;
        private System.Windows.Forms.TextBox txtaddstucont;
        private System.Windows.Forms.TextBox txtaddstuaddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtaddsturoll;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtaddstuname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnshowstud;
        private System.Windows.Forms.DateTimePicker dateTimePickeraddstu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtreason;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnleave;
        private System.Windows.Forms.DataGridView dataGridViewleave;
        private System.Windows.Forms.DateTimePicker dateTimePickerleave;
        private System.Windows.Forms.ComboBox comboBoxleave;
    }
}