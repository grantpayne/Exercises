using System;
using PostageCalculator.Classes;
using System.Collections.Generic;

namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize & populate List of classes
            List<IDeliveryDriver> driverList= new List<IDeliveryDriver>();
            driverList.Add(new PostalServiceFirstClass());
            driverList.Add(new PostalServiceSecondClass());
            driverList.Add(new PostalServiceThirdClass());
            driverList.Add(new FexEd());
            driverList.Add(new SPUFourDayGround());
            driverList.Add(new SPUTwoDayBusiness());
            driverList.Add(new SPUNextDay());
            
            //Initialize variables to be used for user input:
            double weight;
            char unitOfWeight;
            int distance;

            //Gather input from the user:
            Console.Write("Please enter the weight of the package? ");
            weight = Double.Parse(Console.ReadLine());
            Console.Write("(P)ounds of (O)unces? ");
            unitOfWeight = char.Parse(Console.ReadLine());
            Console.Write("What distance will it be traveling? ");
            distance = int.Parse(Console.ReadLine());

            //Convert user input to ounces if entered in pounds:
            if (unitOfWeight == 'P')
            {
                weight *= 16;
            }

            //Print header:
            Console.WriteLine("\nDelivery Method                 $ cost" +
                "\n--------------------------------------");

            //Print rates:
            foreach (IDeliveryDriver driver in driverList)
            {
                Console.WriteLine(driver.Type.PadRight(32) + driver.CalculateRate(distance, weight).ToString("C2"));
            }

            Console.ReadLine();
        }
    }
}
