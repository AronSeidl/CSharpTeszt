using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeKettoskeresztTeszt
{
    internal class NonProfit : Company
    {
        public NonProfit(string name, string address) : base(name, address)
        {
        }

        public override void WriteDescription()
        {
            Console.WriteLine("Segítek az embereken!");
        }
    }
}
