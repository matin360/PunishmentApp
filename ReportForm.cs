using PunismentSystemApp.Components;
using PunismentSystemApp.Core;
using PunismentSystemApp.DB;
using PunismentSystemApp.Models;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PunismentSystemApp
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void link_mainPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Session.MainForm.ShowDialog();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            int x = 6;
            var Punishments = DBcontext.Punishments.GetAll();
            foreach (Punishment punishment in Punishments)
            {
                PunishmentControl punishmentControl = new PunishmentControl();
                Person person = DBcontext.Punishments.FindPersonByPunishment(punishment.UserId);
                punishmentControl.lbl_amount.Text = punishment.Amount.ToString();
                punishmentControl.lbl_date.Text = punishment.PunishDate.ToString();
                punishmentControl.lbl_firstName.Text = person.FirstName;
                punishmentControl.lbl_idCardNumber.Text = person.IdCardNumber;
                punishmentControl.lbl_lastName.Text = person.LastName;
                punishmentControl.lbl_points.Text = punishment.Points.ToString();

                punishmentControl.Location = new Point(x, 21);
                x += 210;
                grbx_report.Controls.Add(punishmentControl);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grbx_report.Controls.Clear();
            int x = 6;

            DateTime StartDate = dtp_start.Value;
            DateTime EndDate = dtp_end.Value;

            var Punishments = DBcontext.Punishments.GetAll();
            foreach (Punishment punishment in Punishments)
            {               
               if (StartDate < punishment.PunishDate && EndDate > punishment.PunishDate)
                {
                    PunishmentControl punishmentControl = new PunishmentControl();
                    Person person = DBcontext.Punishments.FindPersonByPunishment(punishment.UserId);
                    punishmentControl.lbl_amount.Text = punishment.Amount.ToString();
                    punishmentControl.lbl_date.Text = punishment.PunishDate.ToString();
                    punishmentControl.lbl_firstName.Text = person.FirstName;
                    punishmentControl.lbl_idCardNumber.Text = person.IdCardNumber;
                    punishmentControl.lbl_lastName.Text = person.LastName;
                    punishmentControl.lbl_points.Text = punishment.Points.ToString();

                    punishmentControl.Location = new Point(x, 21);
                    x += 210;
                    grbx_report.Controls.Add(punishmentControl);
                }
                else
                {
                    MessageBox.Show("There is no result according to your request");
                    return;
                }
            }
        }

        private void ReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.MainForm.Close();
        }
    }
}
