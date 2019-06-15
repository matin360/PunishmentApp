using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PunismentSystemApp.Models;

namespace PunismentSystemApp.DB
{
    public class DBset<T> where T: class
    {
        private static List<T> items { get; set; }

        static DBset()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        public IEnumerable<T> GetAll()
        {
            return items;
        }

    }
}
