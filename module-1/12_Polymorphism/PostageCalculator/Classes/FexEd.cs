using System;
using System.Collections.Generic;
using System.Text;
using PostageCalculator.Classes;

namespace PostageCalculator.Classes
{
    class FexEd : IDeliveryDriver
    {
        public string Type { get; }

        public FexEd()
        {
            Type = "FexEd";
        }

        public double CalculateRate(int distance, double weight)
        {
            double rate = 20.00;

            if (distance > 500)
            {
                rate += 5.00;
            }

            if (weight > 48)
            {
                rate += 3.00;
            }

            return rate;

        }
    }
}
