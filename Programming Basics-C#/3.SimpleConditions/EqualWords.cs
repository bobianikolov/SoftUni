using System;

class EqualWords
{
    static void Main(string[] args)
    {
        string firstString = Console.ReadLine().ToLower();
        string secondString = Console.ReadLine().ToLower();
        if (firstString == secondString)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

