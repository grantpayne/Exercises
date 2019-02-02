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

            
            string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};

            result += ones[n % 10];

            return result;

        }
    }
}
