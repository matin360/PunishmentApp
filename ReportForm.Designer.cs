namespace PunismentSystemApp
{
    partial class ReportForm
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
            this.link_mainPage = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.grbx_report = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // link_mainPage
            // 
            this.link_mainPage.AutoSize = true;
            this.link_mainPage.Location = new System.Drawing.Point(1289, 9);
            this.link_mainPage.Name = "link_mainPage";
            this.link_mainPage.Size = new System.Drawing.Size(75, 17);
            this.link_mainPage.TabIndex = 0;
            this.link_mainPage.TabStop = true;
            this.link_mainPage.Text = "Main Page";
            this.link_mainPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_mainPage_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dtp_end);
            this.groupBox1.Controls.Add(this.dtp_start);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 200);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(6, 126);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(265, 22);
            this.dtp_end.TabIndex = 1;
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(6, 52);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(265, 22);
            this.dtp_start.TabIndex = 0;
            // 
            // grbx_report
            // 
            this.grbx_report.Location = new System.Drawing.Point(3, 230);
            this.grbx_report.Name = "grbx_report";
            this.grbx_report.Size = new System.Drawing.Size(1369, 361);
            this.grbx_report.TabIndex = 3;
            this.grbx_report.TabStop = false;
            this.grbx_report.Text = "Report";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 595);
            this.Controls.Add(this.grbx_report);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.link_mainPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportForm_FormClosed);
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel link_mainPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.GroupBox grbx_report;
    }
}