using System;
using System.Collections.Generic;
using System.Text;
using TollBoothCalculator.Classes;

namespace TollBoothCalculator.Classes
{
    class Truck : IVehicle
    {
        public double CalculateToll(int distance)
        {
            double ratePerMile;
            double toll;

            if (NumberOfAxles == 4)
            {
                ratePerMile = 0.040;
            }
            else if (NumberOfAxles == 6)
            {
                ratePerMile = 0.045;
            }
            else
            {
                ratePerMile = 0.048;
            }

            toll = ratePerMile * distance;

            return toll;
        }

        public int NumberOfAxles { get; }

        public Truck(int numberOfAxles)
        {
            NumberOfAxles = numberOfAxles;
        }

    }
}
