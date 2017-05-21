using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01CenturiesToMinutes
{
    class CenturiesToMinutes
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            int years = centuries * 100;
            int day = (int) ((double)years * 365.2422);
            ulong hours = (ulong)day * 24;
            ulong minutes = hours * 60;
            Console.WriteLine($"{centuries} centuries = {years} years = {day} days = {hours} hours = {minutes} minutes");         
        }
    }
}
