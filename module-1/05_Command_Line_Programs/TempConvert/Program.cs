using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the temperature: ");
            decimal userTemp = decimal.Parse(Console.ReadLine());
            Console.Write("Is the temperature in (C)elcius, or (F)arenheit? ");
            string userUnit = Console.ReadLine();
            Convert(userTemp, userUnit);
            Console.ReadLine();
        }
        static void Convert(decimal temp, string unit)
        {
            if (unit == "C")
            {
                Console.WriteLine(temp + unit + " is " + Math.Floor((temp * 1.8M + 32)) + "F.");
            }
            else
            {
                Console.WriteLine(temp + unit + " is " + Math.Floor(((temp - 32) / 1.8M)) + "C.");
            }
        }
    }
}
