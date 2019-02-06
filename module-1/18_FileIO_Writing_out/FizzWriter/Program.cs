using System;
using System.IO;

namespace FizzWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("FizzBuzz.txt", false))
                {
                    for (int i = 1; i <= 300; i++)
                    {
                        if (i % 3 == 0 && i % 5 == 0)
                        {
                            sw.WriteLine("FizzBuzz");
                        }
                        else if (i % 5 == 0 || i.ToString().Contains('5'))
                        {
                            sw.WriteLine("Buzz");
                        }
                        else if (i % 3 == 0 || i.ToString().Contains('3'))
                        {
                            sw.WriteLine("Fizz");
                        }
                        else
                        {
                            sw.WriteLine(i);
                            
                        }
                    }
                    
                    
                }
                Console.WriteLine("FizzBuzz.txt has been created.");
                Console.ReadLine();
                
            }
            catch (Exception)
            {

                Console.WriteLine("An exception occured");
                Console.ReadLine();

            }

            
                
        }
    }
}
