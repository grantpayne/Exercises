using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataPrimeFactors
    {

        public List<int> FindPrimeFactors(int input)
        {
            List<int> result = new List<int>();
            for (int i = 2; i <= input; i++)
            {
                while (input % i == 0)
                {
                    result.Add(i);
                    input /= i;
                }
            }
            return result;
        }

    }
}
