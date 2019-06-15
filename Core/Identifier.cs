using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunismentSystemApp.Core
{
    public static class Identifier<T>
    {
        private static int counter { get; set; }

        static Identifier()
        {
            counter = 0;
        }

        public static int GenerateID()
        {
            counter++;
            return counter;
        }
    }
}
