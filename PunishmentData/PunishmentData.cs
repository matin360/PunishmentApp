using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunismentSystemApp
{
    public class PunishmentData
    {
        private Dictionary<byte, PunishmentAmountType> keyValuePairs;

        public PunishmentData()
        {
            keyValuePairs = new Dictionary<byte, PunishmentAmountType>()
            {
                { 1, PunishmentAmountType.Twenty },
                { 2, PunishmentAmountType.Forty },
                { 3, PunishmentAmountType.Sixty },
                { 4, PunishmentAmountType.Eighty },
                { 5, PunishmentAmountType.Hundred },
                { 6, PunishmentAmountType.HundredTwenty },
                { 7, PunishmentAmountType.HundredForty },
                { 8, PunishmentAmountType.HundredSixty },
                { 9, PunishmentAmountType.HundredEighty },
                { 10, PunishmentAmountType.TwoHundred },
            };
        }

        public byte GetPoints(string point)
        {
            byte _point = 0;
            if (!string.IsNullOrEmpty(point))
            {
                _point = byte.Parse(point); 
            }
            return _point;
        }


        public PunishmentAmountType GetPunishAmountType(byte punishmentType)
        {   
            return keyValuePairs[punishmentType];
        }
    }
}
