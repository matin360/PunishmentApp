using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunismentSystemApp.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string IdCardNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string DriverLicenseNumber { get; set; }
        public DateTime DriverLicenseStart { get; set; }
        public DateTime DriverLicenseEnd { get; set; }

        public StatusType StatusIdCard { get; set; }
        public StatusType StatusDriverLicense { get; set; }
        public byte Points { get; set; }
    }
}
