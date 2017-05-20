using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EnterEvenNumbers
{
    static void Main(string[] args)
    {
        int n;
        do
        {
            try
            {
                Console.Write("Enter even number: ");
                 n = int.Parse(Console.ReadLine());
                 if (n % 2 == 0)
                 {
                     break;
                 }
                 Console.WriteLine("The number is not even.");
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid number!");
            }        

        } while (true);
        Console.WriteLine("Even number entered: {0}", n);
    }
}

