using System;
using TollBoothCalculator.Classes;
using System.Collections.Generic;

namespace TollBoothCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomDistance = new Random();
            List<IVehicle> vehicleList = new List<IVehicle>();

            vehicleList.Add(new Car(false));
            vehicleList.Add(new Car(true));
            vehicleList.Add(new Tank());
            vehicleList.Add(new Truck(4));
            vehicleList.Add(new Truck(6));
            vehicleList.Add(new Truck(8));

            Console.WriteLine("Vehicle                  Distance Traveled                Toll $  " +
                "\n-----------------------------------------------------------------");

            foreach (IVehicle vehicle in vehicleList)
            {
                int distance = randomDistance.Next(10, 240);
                string type = GetVehicleType(vehicle);
                Console.WriteLine("{0,-20} {1,15} {2,27:C2}", type, distance, vehicle.CalculateToll(distance));

            }

            Console.ReadLine();
        }

        public static string GetVehicleType(IVehicle vehicle)
        {
            string type = vehicle.GetType().ToString().Substring(28);

            switch (type)
            {
                case "Car":
                    Car car = (Car)vehicle;
                    if (car.HasTrailer)
                    {
                        type += " (with trailer)";
                        
                    }
                    break;
                case "Truck":
                    Truck truck = (Truck)vehicle;
                    type += $" ({truck.NumberOfAxles} axels)";
                    break;
            }

            return type;
        }
            
    }
}
