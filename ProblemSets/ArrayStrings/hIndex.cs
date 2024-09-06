using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.ArrayStrings.HIndex
{
    public class HIndexLeet
    {
        public static int HIndex(int[] citations)
        {
            Array.Sort(citations);
            int count = 0;
            //
            //[0,0,4,4]
            //   |
            while (count < citations.Length && citations[citations.Length - 1 - count] > count)
            {
                count++;
            }
            return count;
        }
    }
}
