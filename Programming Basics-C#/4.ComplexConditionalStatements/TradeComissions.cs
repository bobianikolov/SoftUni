using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08TradeComissions
{
    class TradeComissions
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());
            double comissions = -1.0;
            if (town == "sofia")
            {
                if (0 <= sales && sales <= 500) comissions = 0.05;
                else if (500 <= sales && sales <= 1000) comissions = 0.07;
                else if (1000 <= sales && sales <= 10000) comissions = 0.08;
                else if (sales > 10000) comissions = 0.12;
            }
            if (town == "varna")
            {
                if (0 <= sales && sales <= 500) comissions = 0.045;
                else if (500 <= sales && sales <= 1000) comissions = 0.075;
                else if (1000 <= sales && sales <= 10000) comissions = 0.10;
                else if (sales > 10000) comissions = 0.13;
            }
            if (town == "plovdiv")
            {
                if (0 <= sales && sales <= 500) comissions = 0.055;
                else if (500 <= sales && sales <= 1000) comissions = 0.08;
                else if (1000 <= sales && sales <= 10000) comissions = 0.12;
                else if (sales > 10000) comissions = 0.145;
            }

            if (comissions > -1.0)
            {
                Console.WriteLine("{0:F2}", comissions * sales);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
