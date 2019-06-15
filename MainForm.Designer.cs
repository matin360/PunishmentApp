namespace PunismentSystemApp
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
            this.txbx_idcard = new System.Windows.Forms.TextBox();
            this.grbx_system = new System.Windows.Forms.GroupBox();
            this.grbx_fire = new System.Windows.Forms.GroupBox();
            this.cmbx_points = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.link_reportWindow = new System.Windows.Forms.LinkLabel();
            this.grbx_person = new System.Windows.Forms.GroupBox();
            this.lbl_driverLinNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_points = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbl_idCardNumber = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbl_statusDriverLin = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_driverLinEndDate = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_statusIdCard = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_driverLinStartDate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_birthPlace = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_birthDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_punishDate = new System.Windows.Forms.Label();
            this.lbl_punishAmount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grbx_system.SuspendLayout();
            this.grbx_fire.SuspendLayout();
            this.grbx_person.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbx_idcard
            // 
            this.txbx_idcard.Location = new System.Drawing.Point(150, 78);
            this.txbx_idcard.Name = "txbx_idcard";
            this.txbx_idcard.Size = new System.Drawing.Size(217, 22);
            this.txbx_idcard.TabIndex = 0;
            this.txbx_idcard.Text = "AZE867309";
            // 
            // grbx_system
            // 
            this.grbx_system.Controls.Add(this.grbx_fire);
            this.grbx_system.Controls.Add(this.link_reportWindow);
            this.grbx_system.Controls.Add(this.grbx_person);
            this.grbx_system.Controls.Add(this.btn_search);
            this.grbx_system.Controls.Add(this.label1);
            this.grbx_system.Controls.Add(this.txbx_idcard);
            this.grbx_system.Location = new System.Drawing.Point(12, 12);
            this.grbx_system.Name = "grbx_system";
            this.grbx_system.Size = new System.Drawing.Size(787, 630);
            this.grbx_system.TabIndex = 1;
            this.grbx_system.TabStop = false;
            this.grbx_system.Text = "Punishment System";
            // 
            // grbx_fire
            // 
            this.grbx_fire.Controls.Add(this.lbl_punishAmount);
            this.grbx_fire.Controls.Add(this.label10);
            this.grbx_fire.Controls.Add(this.lbl_punishDate);
            this.grbx_fire.Controls.Add(this.cmbx_points);
            this.grbx_fire.Controls.Add(this.label6);
            this.grbx_fire.Controls.Add(this.btn_submit);
            this.grbx_fire.Controls.Add(this.label3);
            this.grbx_fire.Location = new System.Drawing.Point(472, 186);
            this.grbx_fire.Name = "grbx_fire";
            this.grbx_fire.Size = new System.Drawing.Size(300, 420);
            this.grbx_fire.TabIndex = 5;
            this.grbx_fire.TabStop = false;
            this.grbx_fire.Text = "Fire";
            this.grbx_fire.Visible = false;
            // 
            // cmbx_points
            // 
            this.cmbx_points.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_points.FormattingEnabled = true;
            this.cmbx_points.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbx_points.Location = new System.Drawing.Point(20, 244);
            this.cmbx_points.Name = "cmbx_points";
            this.cmbx_points.Size = new System.Drawing.Size(250, 24);
            this.cmbx_points.TabIndex = 7;
            this.cmbx_points.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbx_points_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(81, 364);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(139, 37);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Points";
            // 
            // link_reportWindow
            // 
            this.link_reportWindow.AutoSize = true;
            this.link_reportWindow.Location = new System.Drawing.Point(668, 18);
            this.link_reportWindow.Name = "link_reportWindow";
            this.link_reportWindow.Size = new System.Drawing.Size(104, 17);
            this.link_reportWindow.TabIndex = 4;
            this.link_reportWindow.TabStop = true;
            this.link_reportWindow.Text = "Report Window";
            this.link_reportWindow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_reportWindow_LinkClicked);
            // 
            // grbx_person
            // 
            this.grbx_person.Controls.Add(this.lbl_driverLinNumber);
            this.grbx_person.Controls.Add(this.label4);
            this.grbx_person.Controls.Add(this.lbl_points);
            this.grbx_person.Controls.Add(this.label21);
            this.grbx_person.Controls.Add(this.lbl_idCardNumber);
            this.grbx_person.Controls.Add(this.label19);
            this.grbx_person.Controls.Add(this.lbl_statusDriverLin);
            this.grbx_person.Controls.Add(this.label16);
            this.grbx_person.Controls.Add(this.lbl_driverLinEndDate);
            this.grbx_person.Controls.Add(this.label15);
            this.grbx_person.Controls.Add(this.lbl_statusIdCard);
            this.grbx_person.Controls.Add(this.label13);
            this.grbx_person.Controls.Add(this.lbl_driverLinStartDate);
            this.grbx_person.Controls.Add(this.label11);
            this.grbx_person.Controls.Add(this.lbl_birthPlace);
            this.grbx_person.Controls.Add(this.label9);
            this.grbx_person.Controls.Add(this.lbl_birthDate);
            this.grbx_person.Controls.Add(this.label7);
            this.grbx_person.Controls.Add(this.lbl_lastName);
            this.grbx_person.Controls.Add(this.label5);
            this.grbx_person.Controls.Add(this.lbl_firstName);
            this.grbx_person.Controls.Add(this.label2);
            this.grbx_person.Location = new System.Drawing.Point(49, 186);
            this.grbx_person.Name = "grbx_person";
            this.grbx_person.Size = new System.Drawing.Size(417, 420);
            this.grbx_person.TabIndex = 3;
            this.grbx_person.TabStop = false;
            this.grbx_person.Text = "Person";
            // 
            // lbl_driverLinNumber
            // 
            this.lbl_driverLinNumber.AutoSize = true;
            this.lbl_driverLinNumber.Location = new System.Drawing.Point(223, 244);
            this.lbl_driverLinNumber.Name = "lbl_driverLinNumber";
            this.lbl_driverLinNumber.Size = new System.Drawing.Size(0, 17);
            this.lbl_driverLinNumber.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Driver License Number:";
            // 
            // lbl_points
            // 
            this.lbl_points.AutoSize = true;
            this.lbl_points.Location = new System.Drawing.Point(223, 387);
            this.lbl_points.Name = "lbl_points";
            this.lbl_points.Size = new System.Drawing.Size(0, 17);
            this.lbl_points.TabIndex = 19;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(25, 387);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 17);
            this.label21.TabIndex = 18;
            this.label21.Text = "Points:";
            // 
            // lbl_idCardNumber
            // 
            this.lbl_idCardNumber.AutoSize = true;
            this.lbl_idCardNumber.Location = new System.Drawing.Point(223, 351);
            this.lbl_idCardNumber.Name = "lbl_idCardNumber";
            this.lbl_idCardNumber.Size = new System.Drawing.Size(0, 17);
            this.lbl_idCardNumber.TabIndex = 17;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(25, 351);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(111, 17);
            this.label19.TabIndex = 16;
            this.label19.Text = "Id Card Number:";
            // 
            // lbl_statusDriverLin
            // 
            this.lbl_statusDriverLin.AutoSize = true;
            this.lbl_statusDriverLin.Location = new System.Drawing.Point(223, 315);
            this.lbl_statusDriverLin.Name = "lbl_statusDriverLin";
            this.lbl_statusDriverLin.Size = new System.Drawing.Size(0, 17);
            this.lbl_statusDriverLin.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 315);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 17);
            this.label16.TabIndex = 14;
            this.label16.Text = "Status of Driver License:";
            // 
            // lbl_driverLinEndDate
            // 
            this.lbl_driverLinEndDate.AutoSize = true;
            this.lbl_driverLinEndDate.Location = new System.Drawing.Point(223, 206);
            this.lbl_driverLinEndDate.Name = "lbl_driverLinEndDate";
            this.lbl_driverLinEndDate.Size = new System.Drawing.Size(0, 17);
            this.lbl_driverLinEndDate.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 17);
            this.label15.TabIndex = 12;
            this.label15.Text = "Driver License End Date:";
            // 
            // lbl_statusIdCard
            // 
            this.lbl_statusIdCard.AutoSize = true;
            this.lbl_statusIdCard.Location = new System.Drawing.Point(223, 280);
            this.lbl_statusIdCard.Name = "lbl_statusIdCard";
            this.lbl_statusIdCard.Size = new System.Drawing.Size(0, 17);
            this.lbl_statusIdCard.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Status of Id Card:";
            // 
            // lbl_driverLinStartDate
            // 
            this.lbl_driverLinStartDate.AutoSize = true;
            this.lbl_driverLinStartDate.Location = new System.Drawing.Point(223, 170);
            this.lbl_driverLinStartDate.Name = "lbl_driverLinStartDate";
            this.lbl_driverLinStartDate.Size = new System.Drawing.Size(0, 17);
            this.lbl_driverLinStartDate.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Driver License Start Date:";
            // 
            // lbl_birthPlace
            // 
            this.lbl_birthPlace.AutoSize = true;
            this.lbl_birthPlace.Location = new System.Drawing.Point(223, 136);
            this.lbl_birthPlace.Name = "lbl_birthPlace";
            this.lbl_birthPlace.Size = new System.Drawing.Size(0, 17);
            this.lbl_birthPlace.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Birth Place:";
            // 
            // lbl_birthDate
            // 
            this.lbl_birthDate.AutoSize = true;
            this.lbl_birthDate.Location = new System.Drawing.Point(223, 105);
            this.lbl_birthDate.Name = "lbl_birthDate";
            this.lbl_birthDate.Size = new System.Drawing.Size(0, 17);
            this.lbl_birthDate.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Birth Date:";
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Location = new System.Drawing.Point(223, 71);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(0, 17);
            this.lbl_lastName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "LastName:";
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Location = new System.Drawing.Point(223, 36);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(0, 17);
            this.lbl_firstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "FirstName:";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(206, 118);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(96, 32);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "IdCardNumber";
            // 
            // lbl_punishDate
            // 
            this.lbl_punishDate.AutoSize = true;
            this.lbl_punishDate.Location = new System.Drawing.Point(97, 46);
            this.lbl_punishDate.Name = "lbl_punishDate";
            this.lbl_punishDate.Size = new System.Drawing.Size(0, 17);
            this.lbl_punishDate.TabIndex = 22;
            // 
            // lbl_punishAmount
            // 
            this.lbl_punishAmount.AutoSize = true;
            this.lbl_punishAmount.Location = new System.Drawing.Point(97, 105);
            this.lbl_punishAmount.Name = "lbl_punishAmount";
            this.lbl_punishAmount.Size = new System.Drawing.Size(0, 17);
            this.lbl_punishAmount.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Amount";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 654);
            this.Controls.Add(this.grbx_system);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "System";
            this.grbx_system.ResumeLayout(false);
            this.grbx_system.PerformLayout();
            this.grbx_fire.ResumeLayout(false);
            this.grbx_fire.PerformLayout();
            this.grbx_person.ResumeLayout(false);
            this.grbx_person.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_idcard;
        private System.Windows.Forms.GroupBox grbx_system;
        private System.Windows.Forms.GroupBox grbx_person;
        private System.Windows.Forms.Label lbl_driverLinEndDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_statusIdCard;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_driverLinStartDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_birthPlace;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_birthDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_idCardNumber;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbl_statusDriverLin;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_points;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbl_driverLinNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel link_reportWindow;
        private System.Windows.Forms.GroupBox grbx_fire;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbx_points;
        private System.Windows.Forms.Label lbl_punishDate;
        private System.Windows.Forms.Label lbl_punishAmount;
        private System.Windows.Forms.Label label10;
    }
}

