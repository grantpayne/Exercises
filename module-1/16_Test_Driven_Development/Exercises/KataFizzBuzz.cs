﻿using System;
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
            else if ((input % 3 == 0 && input % 5 == 0)
                || (input.ToString().Contains('3') && input.ToString().Contains('5')))
            {
                return "FizzBuzz";
            }
            else if (input % 3 == 0 || input.ToString().Contains('3'))
            {
                return "Fizz";
            }
            else if (input % 5 == 0 || input.ToString().Contains('5'))
            {
                return "Buzz";
            }
            else
            {
                return input.ToString();
            }

        }
    }
}
