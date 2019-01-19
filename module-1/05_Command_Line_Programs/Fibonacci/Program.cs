using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the Fibonacci number: ");
            int inputNumber = int.Parse(Console.ReadLine());
            while (inputNumber >= 0)
            {
            Fibonacci(inputNumber);
            Console.WriteLine();
            inputNumber = int.Parse(Console.ReadLine());
            }

        }

        static void Fibonacci(int input)
        {
            int num1 = 0;
            int num2 = 1;

            if (input == 0)
            {
                Console.WriteLine(num1);
            }
            /*
            else if (input == 1)
            {
                Console.WriteLine(num1 + ", " + num2);
            }
            */
            else
            {
                int nextFib = num1 + num2;
                Console.Write(num1 + ", " + num2);
                while (nextFib <= input)
                {
                    Console.Write(", " + nextFib);
                    num1 = num2;
                    num2 = nextFib;
                    nextFib = num1 + num2;
                }
            }
            Console.WriteLine();
            
        }

        /* Recursive Method///////////////////////////////////////////////////////////////////////////////////
        static int Fibonacci(int input)
        {
            int result = 0;

            if (input <= 0)
            {
                return 0;
            }
            else if (input == 1)
            {
                return 1;
            }
            else
            {
                result += Fibonacci(input - 2) + Fibonacci(input - 1);
            }


            return result;
        }
        */

    }
}
