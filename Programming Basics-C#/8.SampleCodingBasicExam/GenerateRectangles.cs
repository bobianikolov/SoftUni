using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GenerateRectangles
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int minArea = int.Parse(Console.ReadLine());
        bool printNo = true;

        for (int left = -n; left <= n; left++)
        {
            for (int top = -n; top <= n; top++)
            {
                for (int bottom = top + 1; bottom <= n; bottom++)
                {
                    for (int right = left + 1; right <= n; right++)
                    {
                        int width = right - left;
                        int height = bottom - top;
                        int area = width * height;
                        if (area >= minArea)
                        {
                            Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", left, top, right, bottom, area);
                            printNo = false;
                        }
                    }
                }
            }
        }

        if (printNo)
        {
            Console.WriteLine("No");
        }
    }
}



