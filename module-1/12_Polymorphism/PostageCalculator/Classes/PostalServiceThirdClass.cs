using System;
using System.Collections.Generic;
using System.Text;
using PostageCalculator.Classes;

namespace PostageCalculator.Classes
{
    class PostalServiceThirdClass : IDeliveryDriver
    {

        public string Type { get; }

        public PostalServiceThirdClass()
        {
            Type = "Postal Service (3rd Class)";
        }


        public double CalculateRate(int distance, double weight)
        {
            double rate;

            if (weight <= 2.0)
            {
                rate = 0.0020 * distance;
            }
            else if (weight <= 8)
            {
                rate = 0.0022 * distance;
            }
            else if (weight <= 15)
            {
                rate = 0.0024 * distance;
            }
            else if (weight <= 48)
            {
                rate = 0.0150 * distance;
            }
            else if (weight <= 128)
            {
                rate = 0.0160 * distance;
            }
            else
            {
                rate = 0.0170 * distance;
            }

            return rate;
        }
    }
}
