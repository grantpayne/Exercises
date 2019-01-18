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
         Given an int array, return true if the array contains 2 twice, or 3 twice. The array will
         be length 0, 1, or 2.
         double23([2, 2]) → true
         double23([3, 3]) → true
         double23([2, 3]) → false
         */
        public bool Double23(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return false;
            }

            int twos = 0;
            int threes = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 2)
                {
                    twos++;
                }
                else if (nums[i] == 3)
                {
                    threes++;
                }


            }
            return twos > 1 || threes > 1;
            //return twos > 1 || threes > 1  ? true : false;
        }
    }
}
