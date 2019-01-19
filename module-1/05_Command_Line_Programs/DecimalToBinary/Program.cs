using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter in a series of decimal values (separated by spaces):");
            string userInput = Console.ReadLine();
            string[] userValues = userInput.Split(" ");
            for (int i = 0; i < userValues.Length; i++)
            {
                Console.WriteLine(userValues[i] + " in binary is " + BinaryConvert(int.Parse(userValues[i])));
            }
            Console.ReadLine();
        }
        static String BinaryConvert(int input)
        {
            string result = "";
            while (input >= 1)
            {
                result = (input % 2).ToString() + result;
                input /= 2;

            }
            return result;
        }
    }
}
