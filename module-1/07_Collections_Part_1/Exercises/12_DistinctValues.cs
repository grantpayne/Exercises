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
         Given a list of strings, return a list that contains the distinct values. In other words, no value is to be
         included more than once in the returned list. (Hint: Think HashSet)
         DistinctValues( ["red", "yellow", "green", "yellow", "blue", "green", "purple"] ) -> ["red", "yellow", "green", "blue", "purple"]
         DistinctValues( ["jingle", "bells", "jingle", "bells", "jingle", "all", "the", "way"] ) -> ["jingle", "bells", "all", "the", "way"]
         */
        public List<string> DistinctValues(List<string> stringList)
        {
            List<string> result = new List<string>();

            HashSet<string> myHash = new HashSet<string>();

            for (int i = 0; i < stringList.Count; i++)
            {
                myHash.Add(stringList[i]);
            }

            for (int i = 0; i < myHash.Count; i++)
            {
                result.Add(myHash.ElementAt(i));
            }

            return result;
        }
    }
}
