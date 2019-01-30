using System;
using System.Collections.Generic;
using System.Text;
using PostageCalculator.Classes;

namespace PostageCalculator.Classes
{
    class SPUFourDayGround : IDeliveryDriver
    {
        public string Type { get; }

        public SPUFourDayGround()
        {
            Type = "SPU (4-Day Ground)";
        }

        public double CalculateRate(int distance, double weight)
        {
            //Must convert weight back into pounds:
            return ((weight / 16.00) * 0.0050) * distance;
        }
    }
}
