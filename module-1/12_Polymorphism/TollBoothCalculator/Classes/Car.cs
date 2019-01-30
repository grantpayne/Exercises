using System;
using System.Collections.Generic;
using System.Text;
using TollBoothCalculator.Classes;


namespace TollBoothCalculator.Classes
{
    class Car : IVehicle
    {
        public bool HasTrailer { get; }

        public double CalculateToll(int distance)
        {
            double toll = 0.0;
            toll = distance * 0.020;
            if (HasTrailer)
            {
                toll++;
            }
            return toll;
        }

        public Car(bool hasTrailer)
        {
            HasTrailer = hasTrailer;
        }


    }
}
