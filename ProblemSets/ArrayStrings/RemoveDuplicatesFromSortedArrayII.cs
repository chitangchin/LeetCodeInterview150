using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.ArrayStrings.RemoveDuplicatesFromSortedArrayII
{
    public class RemoveDuplicatesFromSortedArrayIILeet
    {
        public static int RemoveDuplicates(int[] nums)
        {
            // | - i - 1 = 0
            //   | - i = 1
            //[1,1,1,2,2,3]
            // | - count = 2
            // | - toFillIn = 1
            if (nums.Length < 3) return nums.Length;
            int count = 1;
            int toFillIn = 1;
            for (int i = 1; i < nums.Length; i++)
            { // go through each item
              // nums[0] == nums[1] count++
                if (nums[i - 1] == nums[i])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count <= 2)
                { //  this i should be replace by next value.
                    Console.WriteLine(nums[toFillIn]);
                    nums[toFillIn++] = nums[i];
                }
            }
            return toFillIn;
        }
    }
}
