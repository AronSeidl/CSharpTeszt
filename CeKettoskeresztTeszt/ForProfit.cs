using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeKettoskeresztTeszt
{
    internal class ForProfit : Company, ICanBuyStock
    {
        public ForProfit(string name, string address) : base(name, address)
        {
        }

        public void BuyStock()
        {
            Console.WriteLine("Részvényt veszek!");
        }

        public override void WriteDescription()
        {
            Console.WriteLine("Pénzt termelek a tulajdonosoknak!");
        }
    }
}
