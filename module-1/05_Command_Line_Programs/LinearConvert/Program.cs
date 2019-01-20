using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length: ");
            decimal userLength = decimal.Parse(Console.ReadLine());
            Console.Write("Is the measurement in (m)eter, or (f)eet? ");
            string userUnit = Console.ReadLine();
            Convert(userLength, userUnit);
            Console.ReadLine();

        }

        static void Convert(decimal length, string unit)
        {
            //Used Math.Floor on results in order to match rounded-down results as presented in specification.
            if (unit == "m")
            {
                Console.WriteLine(length + unit + " is " + Math.Floor((length * 3.2808399M)) + "f.");
            }
            else
            {
                Console.WriteLine(length + unit + " is " + Math.Floor((length * 0.3048M)) + "m.");

            }

        }
    }
}
