using System;
using System.Collections.Generic;
using System.Text;
using PostageCalculator.Classes;

namespace PostageCalculator.Classes
{
    class SPUNextDay : IDeliveryDriver
    {

        public string Type { get; }

        public SPUNextDay()
        {
            Type = "SPU (Next Day)";
        }

        public double CalculateRate(int distance, double weight)
        {
            //Must convert weight back into pounds:
            return ((weight / 16.00) * 0.075) * distance;
        }

    }
}
