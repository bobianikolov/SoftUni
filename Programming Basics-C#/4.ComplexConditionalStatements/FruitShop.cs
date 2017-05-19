using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double price = -1.0;
            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                switch (fruit)
                {
                    case "banana": price = quantity * 2.50; break;
                    case "apple": price = quantity * 1.20; break;
                    case "orange": price = quantity * 0.85; break;
                    case "grapefruit": price = quantity * 1.45; break;
                    case "kiwi": price = quantity * 2.70; break;
                    case "pineapple": price = quantity * 5.50; break;
                    case "grapes": price = quantity * 3.85; break;
                }
            }
            if (day == "saturday" || day == "sunday")
            {
                switch (fruit)
                {
                    case "banana": price = quantity * 2.70; break;
                    case "apple": price = quantity * 1.25; break;
                    case "orange": price = quantity * 0.90; break;
                    case "grapefruit": price = quantity * 1.60; break;
                    case "kiwi": price = quantity * 3.00; break;
                    case "pineapple": price = quantity * 5.60; break;
                    case "grapes": price = quantity * 4.20; break;
                }
            }
            if (price >= 0)
            {
                Console.WriteLine("{0:F2}", price);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
