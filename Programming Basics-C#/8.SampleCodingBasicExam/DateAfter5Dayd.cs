using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DateAfter5Dayd
{
    static void Main(string[] args)
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        day = day + 5;
        int daysofmonth = 31;

        if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            daysofmonth = 30;
        }
        else if (month == 2)
        {
            daysofmonth = 28;
        }
        if (day > daysofmonth)
        {
            day = day - daysofmonth;
            month++;
            if (month == 13)
            {
                month = 1;
            }
        }
        if (month < 10)
        {
            Console.WriteLine("{0}.0{1}", day, month);
        }
        else
        {
            Console.WriteLine("{0}.{1}", day, month);
        }
    }
}

