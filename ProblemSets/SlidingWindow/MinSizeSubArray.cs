using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.SlidingWindow.MinSizeSubArray
{
    public class MinSizeSubArrayLeet
    {
        public static int MinSubArrayLen(int target, int[] nums)
        {
            int result = int.MaxValue, runningSum = 0, left = 0;

            for (var right = 0; right < nums.Length; right++)
            {

                runningSum += nums[right];

                while (runningSum >= target)
                {

                    result = Math.Min(result, right - left + 1);

                    runningSum -= nums[left];

                    left++;
                }
            }
            return result == int.MaxValue ? 0 : result;
        }
    }
}
