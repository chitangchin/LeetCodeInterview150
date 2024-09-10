using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.HashMap.ContainsDupII
{
    public class ContainsDupIILeet
    {
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    if (Math.Abs(map[nums[i]] - i) <= k) return true;
                    else
                    {
                        map[nums[i]] = i;
                    }
                }
                else
                {
                    map[nums[i]] = i;
                }
            }
            return false;
        }
    }
}
