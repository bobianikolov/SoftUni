using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekends = int.Parse(Console.ReadLine());
            double result = weekends + (48 - weekends) * (3.0 / 4)  + holidays * (2.0 / 3);
            if (season == "normal")
	        {
                Console.WriteLine(Math.Truncate(result));		        
	        }
            else if (season == "leap")
            {
                double leap = result + 0.15 * result;
                Console.WriteLine(Math.Truncate(leap));		        
            }
        }
    }
}
