using PunismentSystemApp.DB;
using PunismentSystemApp.Models;
using PunismentSystemApp.Core;
using System;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace PunismentSystemApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            string idCardNumber = txbx_idcard.Text;
            if (string.IsNullOrEmpty(idCardNumber))
                MessageBox.Show("Please, enter Id Card Number");

            else if (DBcontext.People.GetAll().Where(x => x.IdCardNumber == idCardNumber).Any())
            {
                grbx_fire.Visible = true;
                Person person = DBcontext.People.GetAll().FirstOrDefault(x => x.IdCardNumber == idCardNumber);
                GetStatusByPersonPoints(person);
                lbl_firstName.Text = person.FirstName;
                lbl_lastName.Text = person.LastName;
                lbl_idCardNumber.Text = person.IdCardNumber;
                lbl_birthDate.Text = person.BirthDate.ToString("yyyy-mm-dd");
                lbl_birthPlace.Text = person.BirthPlace;
                lbl_driverLinEndDate.Text = person.DriverLicenseEnd.ToString("yyyy-mm-dd");
                lbl_driverLinStartDate.Text = person.DriverLicenseStart.ToString("yyyy-mm-dd");
                lbl_points.Text = person.Points.ToString();
                lbl_driverLinNumber.Text = person.DriverLicenseNumber;
                lbl_statusIdCard.Text = person.StatusIdCard.ToString();
                lbl_statusDriverLin.Text = person.StatusDriverLicense.ToString();
            }
            else
            {
                MessageBox.Show("There is no result according to your input");
            }    
        }

        private void link_reportWindow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Session.MainForm = this;
            Hide();
            new ReportForm().ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idCardNumber = txbx_idcard.Text;
            var people = DBcontext.People.GetAll();
            Person person = people.FirstOrDefault(x => x.IdCardNumber == idCardNumber);
            if (string.IsNullOrEmpty(cmbx_points.Text))
            {
                MessageBox.Show("You have not input all info");
            }
            else if(string.IsNullOrEmpty(idCardNumber))
            {
                MessageBox.Show("Please, define a person who is suposed to be punished");
            }
            else if(person != null)
            {
                PunishmentData punishmentData = new PunishmentData();
                byte points = punishmentData.GetPoints(cmbx_points.Text);
                PunishmentAmountType punishmentAmountType = punishmentData.GetPunishAmountType(points);
                Punishment punishment = new Punishment()
                {
                    Id = Identifier<Punishment>.GenerateID(),
                    UserId = person.Id,
                    Points = points,
                    Amount = punishmentAmountType,
                    PunishDate = DateTime.Now
                };
                lbl_punishDate.Text = punishment.PunishDate.ToString();
                lbl_punishAmount.Text = punishment.Amount.ToString() + " AZN";
                person.Points += points;
                DBcontext.Punishments.Add(punishment);
            }
           
            

        }

        private void GetStatusByPersonPoints(Person person)
        {
            if (person.Points < 10)
            {
                person.StatusIdCard = StatusType.Open;
                person.StatusDriverLicense = StatusType.Open;
            }
            else
            {
                person.StatusIdCard = StatusType.Blocked;
                person.StatusDriverLicense = StatusType.Blocked;
            }
        }

        private void cmbx_points_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
