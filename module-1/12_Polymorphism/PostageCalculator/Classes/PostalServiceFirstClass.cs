using System;
using System.Collections.Generic;
using System.Text;
using PostageCalculator.Classes;

namespace PostageCalculator.Classes
{
    class PostalServiceFirstClass : IDeliveryDriver
    {

        public string Type { get; }

        public PostalServiceFirstClass()
        {
            Type = "Postal Service (1st Class)";
        }

        public double CalculateRate(int distance, double weight)
        {
            double rate;

            if (weight <= 2.0)
            {
                rate = 0.035 * distance;
            }
            else if (weight <= 8)
            {
                rate = 0.040 * distance;
            }
            else if (weight <= 15)
            {
                rate = 0.047 * distance;
            }
            else if (weight <= 48)
            {
                rate = 0.195 * distance;
            }
            else if (weight <= 128)
            {
                rate = 0.450 * distance;
            }
            else
            {
                rate = 0.500 * distance;
            }

            return rate;
        }

    }
}
