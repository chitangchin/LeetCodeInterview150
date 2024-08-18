using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.ArrayStrings.RemoveDuplicates
{
    public class SolutionClass
    {
        public static int RemoveDuplicates(int[] nums)
        {
            //Store index
            int currIndex = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                //Check if element is unique
                if (nums[i - 1] != nums[i])
                {
                    //If unique define the nums[currIndex] to nums[i]
                    nums[currIndex++] = nums[i];
                }
            }
            //Return the total count of unique elements
            return currIndex;
        }
    }
}
