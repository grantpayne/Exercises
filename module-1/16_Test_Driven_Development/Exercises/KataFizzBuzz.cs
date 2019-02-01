using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataFizzBuzz
    {
        public string FizzBuzz(int input)
        {
            if (input <= 0 || input > 100)
            {
                return "";
            }
            else if (input % 3 == 0 && input % 5 == 0)
            {
                return "FizzBuzz";
            }

            else return "nothing";
        }
    }
}
