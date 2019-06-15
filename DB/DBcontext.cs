using PunismentSystemApp.Core;
using PunismentSystemApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PunismentSystemApp.DB
{
    public static class DBcontext
    {
        public static DBset<Person> People { get; set; }
        public static DBset<Punishment> Punishments { get; set; }
        private static void AddDefaultPeople()
        {
            Person person1 = new Person
            {
                Id = Identifier<Person>.GenerateID(),
                FirstName = "User",
                LastName = "Userov",
                IdCardNumber = "AZE234567",
                BirthDate = new DateTime(1990, 3, 25),
                BirthPlace = "Absheron",
                DriverLicenseNumber = "345678",
                DriverLicenseStart = new DateTime(1990, 3, 25),
                DriverLicenseEnd = new DateTime(1990, 3, 25),
            };
            Person person2 = new Person
            {
                Id = Identifier<Person>.GenerateID(),
                FirstName = "Ahmed",
                LastName = "Userov",
                IdCardNumber = "AZE193845",
                BirthDate = new DateTime(1985, 3, 25),
                BirthPlace = "Absheron",
                DriverLicenseNumber = "345678",
                DriverLicenseStart = new DateTime(2017, 3, 25),
                DriverLicenseEnd = new DateTime(2022, 3, 25)
            };
            Person person3 = new Person
            {
                Id = Identifier<Person>.GenerateID(),
                FirstName = "Etibar",
                LastName = "Userov",
                IdCardNumber = "AZE710485",
                BirthDate = new DateTime(1980, 3, 25),
                BirthPlace = "Xirdalan",
                DriverLicenseNumber = "345678",
                DriverLicenseStart = new DateTime(2014, 3, 25),
                DriverLicenseEnd = new DateTime(2019, 9, 25)
            };
            Person person4 = new Person
            {
                Id = Identifier<Person>.GenerateID(),
                FirstName = "Tural",
                LastName = "Userov",
                IdCardNumber = "AZE867309",
                BirthDate = new DateTime(1995, 3, 25),
                BirthPlace = "Absheron",
                DriverLicenseNumber = "345678",
                DriverLicenseStart = new DateTime(2016, 3, 25),
                DriverLicenseEnd = new DateTime(2021, 3, 25)
            };
            Person person5 = new Person
            {
                Id = Identifier<Person>.GenerateID(),
                FirstName = "Sahil",
                LastName = "Userov",
                IdCardNumber = "AZE196347",
                BirthDate = new DateTime(1992, 3, 25),
                BirthPlace = "Hovsan",
                DriverLicenseNumber = "345678",
                DriverLicenseStart = new DateTime(2015, 3, 25),
                DriverLicenseEnd = new DateTime(2020, 3, 25)
            };
            People.Add(person1);
            People.Add(person2);
            People.Add(person3);
            People.Add(person4);
            People.Add(person5);
        }
        static DBcontext()
        { 
            Punishments = new DBset<Punishment>();
            People = new DBset<Person>();
            AddDefaultPeople();
        }        
    }
}
