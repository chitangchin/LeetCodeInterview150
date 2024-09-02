using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.HashMap.TwoSum
{
    public class TwoSumLeet
    {
        public static int[]? TwoSum(int[] nums, int target)
        {
            //One Pass Hashmap
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    return [map[nums[i]], i];
                }
                map[target - nums[i]] = i;
            }
            return null;
        }
    }
}
