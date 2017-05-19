using System;

class SumSecond
    
{
    static void Main(string[] args)
    {
       int sec1 =int.Parse(Console.ReadLine());
       int sec2 =int.Parse(Console.ReadLine());
       int sec3 =int.Parse(Console.ReadLine());
       int seconds = sec1 + sec2 + sec3;
       int minutes = 0;

        if (seconds >= 60)
        {
            minutes = minutes + 1;
            seconds = seconds - 60;
        }
        if (seconds >= 60)
        {
            minutes = minutes + 1;
            seconds = seconds - 60;
        }
        if (seconds < 10)
        {
            Console.WriteLine(minutes + ":0" + seconds);
        }
        else
        {
            Console.WriteLine(minutes + ":" + seconds);
        }
    }
}

