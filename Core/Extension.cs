using PunismentSystemApp.Models;
using PunismentSystemApp.DB;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PunismentSystemApp.Core
{
    public static class Extension
    {

        public static Person FindPersonByPunishment(this DBset<Punishment> dBset, int UserId )
        {
            Person _person = new Person();
            foreach (Person person in DBcontext.People.GetAll())
            {
                if (person.Id == UserId)
                {
                    _person = person; 
                }
            }
            return _person;
        }

        public static Punishment GetPunishmentBetweenRange(this DBset<Punishment> dBset, DateTime startDate, DateTime endDate)
        {
            Punishment _punishment = new Punishment();
            foreach (Punishment punishment in DBcontext.Punishments.GetAll())
            {
                if (punishment.PunishDate > startDate && punishment.PunishDate < endDate)
                {
                    _punishment = punishment;
                }
            }
            return _punishment;
        }
    }
}
