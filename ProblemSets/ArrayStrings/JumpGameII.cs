using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.ArrayStrings.JumpGameII
{
    public class JumpGameIILeet
    {
        public static int Jump(int[] nums)
        {
            /*
            nums.Length - 5
            end - 0 -> 2
            far - 0 -> 2 -> 4
            jumps - 0 -> 1
            i - 0 -> 1 -> 2
            nums[i] + i - 2 -> 1 + 3 = 4
            */
            int end = 0, far = 0, jumps = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                far = Math.Max(far, nums[i] + i);
                if (i == end)
                {
                    end = far;
                    jumps++;
                }
            }
            return jumps;
        }
    }
}
