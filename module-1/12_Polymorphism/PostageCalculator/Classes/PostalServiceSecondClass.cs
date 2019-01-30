using System;
using System.Collections.Generic;
using System.Text;
using PostageCalculator.Classes;

namespace PostageCalculator.Classes
{
    class PostalServiceSecondClass : IDeliveryDriver
    {

        public string Type { get; }

        public PostalServiceSecondClass()
        {
            Type = "Postal Service (2nd Class)";
        }

        public double CalculateRate(int distance, double weight)
        {
            double rate;

            if (weight <= 2.0)
            {
                rate = 0.0035 * distance;
            }
            else if (weight <= 8)
            {
                rate = 0.0040 * distance;
            }
            else if (weight <= 15)
            {
                rate = 0.0047 * distance;
            }
            else if (weight <= 48)
            {
                rate = 0.0195 * distance;
            }
            else if (weight <= 128)
            {
                rate = 0.0450 * distance;
            }
            else
            {
                rate = 0.0500 * distance;
            }

            return rate;
        }

    }
}
