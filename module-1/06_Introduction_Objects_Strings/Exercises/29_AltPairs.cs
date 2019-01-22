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
         Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so "kittens" yields "kien".
         AltPairs("kitten") → "kien"
         AltPairs("Chocolate") → "Chole"
         AltPairs("CodingHorror") → "Congrr"
         */
        public string AltPairs(string str)
        {
            if (str.Length < 3)
            {
                return str;
            }

            string returnStr = "";

            for (int i = 0; i < str.Length; i += 4)
            {
                if (str.Length >= i + 2)
                {
                    returnStr += str.Substring(i, 2);
                }
                else if (str.Length >= i + 1)
                {
                    returnStr += str.Substring(i, 1);
                }
            }
            return returnStr;
        }
    }
}
