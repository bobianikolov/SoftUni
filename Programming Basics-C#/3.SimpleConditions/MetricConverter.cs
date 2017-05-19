using System;

class MetricConverter
{
    static void Main(string[] args)
    {
        double size = double.Parse(Console.ReadLine());
        string  inputUnit = Console.ReadLine().ToLower();
        string  outputUnit = Console.ReadLine().ToLower();

        if (inputUnit == "km")
        {
            size /= 0.001;
        }
        else if (inputUnit == "mm")
        {
            size /= 1000;
        }
        else if (inputUnit == "cm")
        {
            size /= 100;
        }
        else if (inputUnit == "mi")
        {
            size /= 0.000621371192;
        }
        else if (inputUnit == "in")
        {
            size /= 39.3700787;
        } 
        else if (inputUnit == "ft")
        {
            size /= 3.2808399;
        }
        else if (inputUnit == "yd")
        {
            size /= 1.0936133;
        }


        if (outputUnit == "ft")
        {
            size *= 3.2808399;

        }
        else if (outputUnit == "cm")
        {
            size *= 100;
        }
        else if (outputUnit == "mi")
        {
            size *= 0.000621371192;
        }
        else if (outputUnit == "in")
        {
            size *= 39.3700787;
        }
        else if (outputUnit == "km")
        {
            size *= 0.001;
        }
        else if (outputUnit == "ft")
        {
            size *= 3.2808399;
        }
        else if (outputUnit == "yd")
        {
            size *= 1.0936133;
        }
        else if (outputUnit == "mm")
        {
            size *= 1000;
        }
        
        Console.WriteLine(size + " " + outputUnit);
    }
}

