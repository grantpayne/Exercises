using System;
using System.Collections.Generic;
using System.Text;
using PostageCalculator.Classes;

namespace PostageCalculator.Classes
{
    class SPUTwoDayBusiness : IDeliveryDriver
    {
        public string Type { get; }

        public SPUTwoDayBusiness()
        {
            Type = "SPU (2-Day Business)";
        }

        public double CalculateRate(int distance, double weight)
        {
            //Must convert weight back into pounds:
            return ((weight / 16.00) * 0.050) * distance;
        }


    }
}
