using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09AnimalType
{
    class AnimalType
    {
        static void Main(string[] args)
        {
            string animals = Console.ReadLine();
            switch (animals)
            {
                case "dog": Console.WriteLine("mammal");break;
                case "crocodile":
                case "tortoise":
                case "snake": Console.WriteLine("reptile");break;
                default: Console.WriteLine("unknown");break;
            }
        }
    }
}