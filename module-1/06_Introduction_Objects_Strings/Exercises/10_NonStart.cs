using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given 2 strings, return their concatenation, except omit the first char of each. The strings will
         be at least length 1.
         NonStart("Hello", "There") → "ellohere"
         NonStart("java", "code") → "avaode"
         NonStart("shotl", "java") → "hotlava"
         */
        public string NonStart(string a, string b)
        {
            a = a.Substring(1);
            b = b.Substring(1);

            return a + b;
        }
    }
}
