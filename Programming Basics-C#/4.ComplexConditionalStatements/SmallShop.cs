using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02SmallShop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string town = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0.0;
            if (town == "sofia")
            {
                switch (product)
                {
                    case "coffee": price = quantity * 0.50; break;
                    case "water": price = quantity * 0.80; break;
                    case "beer": price = quantity * 1.20; break;
                    case "sweets": price = quantity * 1.45; break;
                    case "peanuts": price = quantity * 1.60; break;
                }
            }
            else if (town == "plovdiv")
            {
                switch (product)
                {
                    case "coffee": price = quantity * 0.40; break;
                    case "water": price = quantity * 0.70; break;
                    case "beer": price = quantity * 1.15; break;
                    case "sweets": price = quantity * 1.30; break;
                    case "peanuts": price = quantity * 1.50; break;
                }
            }
            else if (town == "varna")
            {
                switch (product)
                {
                    case "coffee": price = quantity * 0.45; break;
                    case "water": price = quantity * 0.70; break;
                    case "beer": price = quantity * 1.10; break;
                    case "sweets": price = quantity * 1.35; break;
                    case "peanuts": price = quantity * 1.55; break;
                }
            }
            Console.WriteLine(price);
        }
    }
}
