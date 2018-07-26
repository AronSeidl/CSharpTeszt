using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeKettoskeresztTeszt
{
    abstract class Company
    {

        readonly string name;
        public string Address { get; private set; }

        public Company(string name, string address)
        {
            this.name = name;
            Address = address;
        }

        public void WriteData()
        {
            Console.WriteLine("Név: {0}\nTelephely: {1}", name, Address);
        }
        public abstract void WriteDescription();
    }
}

