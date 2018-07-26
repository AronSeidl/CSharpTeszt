using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeKettoskeresztTeszt
{
    class Broker : ICanBuyStock
    {
        public void BuyStock()
        {
            Console.WriteLine("Részvényt veszek!");
        }
    }
}
