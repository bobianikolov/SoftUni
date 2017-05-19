using System;
class UsdTOBgn
{
    static void Main(string[] args)
    {
        decimal usd = decimal.Parse(Console.ReadLine());
        decimal bgn = usd * 1.79549M;
        Console.WriteLine("{0:F2} BGN", bgn);
    }
}

