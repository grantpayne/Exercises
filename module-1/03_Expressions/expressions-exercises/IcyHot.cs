﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given two temperatures, return true if one is less than 0 and the other is greater than 100.
         IcyHot(120, -1) → true
         IcyHot(-1, 120) → true
         IcyHot(2, 120) → false
         */
        public bool IcyHot(int temp1, int temp2)
        {
            if (temp1 < 0)
            {
                if (temp2 > 100)
                {
                    return true;
                }
            }
            else if (temp2 < 0)
            {
                if (temp1 > 100)
                {
                    return true;
                }
            }
            return false;
        }   

    }
}