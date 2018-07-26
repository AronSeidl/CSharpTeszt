using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeKettoskeresztTeszt
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = new Pair<string>("item1", "item2");
            List<Company> companies = new List<Company>();
            companies.Add(new ForProfit("Progmatic", "Csemete utca 5."));
            companies.Add(new NonProfit("Vöröskereszt", "Kórház tér 2."));

            foreach (var company in companies)
            {
                company.WriteData();
                company.WriteDescription();
                Console.WriteLine("\n");
            }
            List<ICanBuyStock> moneyMoneyMoney = new List<ICanBuyStock>();
            moneyMoneyMoney.Add(new ForProfit("Progmatic", "Csemete utca 5."));
            moneyMoneyMoney.Add(new Broker());

            foreach (var paylot in moneyMoneyMoney)
            {
                paylot.BuyStock();
            }
            item.HasQueried += Item_HasQueried;
            string gettedValue = item.Item2;

            List<int> tesztlista = new List<int> { 1, 3, 5, 2, 4, 8, 9 };
            Console.WriteLine("\n" + ListExtension.findSecond(tesztlista, valaminevet));

            string path = Console.ReadLine();
            if (!File.Exists(path))
            {
                WriteExist(path);
            }
            else
            {
                string text = File.ReadAllText(path);
                Console.WriteLine(text);
            }

            Console.ReadKey();
        }

        private static void WriteExist(string path)
        {
            
            using (StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Create)))
            {
                sw.Write("Létezett!!!");
            }
        }

        private static bool valaminevet(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            return false;
        }

        private static void Item_HasQueried(int item)
        {
            Console.WriteLine("\nvalaki elkérte az elemet: " + item);
        }

       
    }
}
