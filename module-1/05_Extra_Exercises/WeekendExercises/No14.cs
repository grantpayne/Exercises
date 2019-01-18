using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {


        /*
         Given an array of ints, return true if it contains no 1's or it contains no 4's.
         no14([1, 2, 3]) → true
         no14([1, 2, 3, 4]) → false
         no14([2, 3, 4]) → true
         */
        public bool No14(int[] nums)
        {
            bool isThereOne = false;
            bool isThereFour = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    isThereOne = true;
                }
                else if (nums[i] == 4)
                {
                    isThereFour = true;
                }
            }
            if (isThereOne == true && isThereFour == true)
            {
                return false;
            }
            else
            {
                return true;
            }

    

           //return !(isThereOne || isThereFour);
        }
    }
}
