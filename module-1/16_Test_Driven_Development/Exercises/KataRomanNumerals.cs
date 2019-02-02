using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataRomanNumerals
    {
        public string ConvertToRomanNumeral(int n)
        {
            string result = "";

            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};

            result += tens[(n / 10) % 10];
            result += ones[n % 10];

            return result;

        }
    }
}
