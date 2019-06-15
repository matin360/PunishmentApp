using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunismentSystemApp.Models
{
    public class Punishment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime PunishDate { get; set; }
        public PunishmentAmountType Amount { get; set; }
        public byte Points { get; set; }
    }
}
