using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__1_7
{
    internal class BMW : Car
    {

        public BMW(string maker, int year, string type, double price, string model, int palletNumber, string color)
             : base(maker, year, type, price, model, palletNumber, color)
        {
            // the constructor is empty because there's no new info to add
        }
    }
}
