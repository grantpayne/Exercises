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

            if (n >= 0 && n <= 3999)
            {
                string[] thousands = { "", "M", "MM", "MMM" };
                string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
                string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
                string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

                result += thousands[(n / 1000) % 10];
                result += hundreds[(n / 100) % 10];
                result += tens[(n / 10) % 10];
                result += ones[n % 10];
            }
            else
            {
                result = "Value out of range - Please enter a number in the range 0-3999.";
            }

            return result;

        }

        public int ConvertToDigit(string romanNumeral)
        {
            return 0;
        }
    }
}
