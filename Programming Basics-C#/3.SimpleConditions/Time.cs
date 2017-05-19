using System;
class TimeMinutes
{
    static void Main(string[] args)
    {
        int hour = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        minutes = minutes + 15;

        if (minutes >= 60)
        {
            hour = hour + 1;
            minutes = minutes - 60;

            if(hour >= 24)
            {
                hour = hour - 24;
            }
        }
        Console.WriteLine("{0}:{01:00}", hour, minutes);
    }
}

