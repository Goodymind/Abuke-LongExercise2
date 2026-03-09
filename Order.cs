using Abuke_LongExercise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace Abuke_LongExercise2
{
    internal class Order
    {
        public List<Item> Items { get; set; }

        public int OrderID { get; set; }

        public Order(int id) 
        {
            Items = new List<Item>();
            OrderID = id;
        }
    }
}
