using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.ArrayStrings.RotateArray
{
    public class RotateLeet
    {
        public static int[] Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            int mid = nums.Length - k;
            int[] left = nums[0..mid];
            int[] right = nums[mid..];
            var result = right.Concat(left).ToArray();
            Array.Copy(result, nums, result.Length);
            return nums;
        }
    }
}
