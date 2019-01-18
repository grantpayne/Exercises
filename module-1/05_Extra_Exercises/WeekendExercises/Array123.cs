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
         Given an array of ints, return true if .. 1, 2, 3, .. appears in the array somewhere.
         array123([1, 1, 2, 3, 1]) → true
         array123([1, 1, 2, 4, 1]) → false
         array123([1, 1, 2, 1, 2, 3]) → true
         */
        public bool Array123(int[] nums)
        {
            if (nums.Length < 3)
            {
                return false;
            }
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] == 1 && nums[i + 1] == 2 && nums[i + 2] == 3)
                {
                    return true;
                }
                
            }
            return false;
            
            //////////////////////////////////////////////////////////////////////////
            //More Verbose solution - which is better? Both of these solutions pass the tests.
            
            /*
            if (nums.Length < 3)
            {
                return false;
            }

            if (nums[0] == 1 && nums[1] == 2 && nums[2] == 3)
            {
                return true;
            }

            int value1InSequence = nums[0];
            int value2InSequence = nums[1];
            int value3InSequence = nums[2];

            for (int i = 3; i < nums.Length; i++)
            {
                value1InSequence = value2InSequence;
                value2InSequence = value3InSequence;
                value3InSequence = nums[i];
                if (value1InSequence == 1 && value2InSequence == 2 && value3InSequence == 3)
                {
                    return true;
                }
            }
            return false;
            */

        }
    }
}
