using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.ArrayStrings.JumpGame
{
    public class JumpGameLeet
    {
        public static bool CanJump(int[] nums)
        {
            int maxJump = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > maxJump) return false;

                maxJump = Math.Max(maxJump, nums[i] + i);

                if (maxJump >= nums.Length - 1) return true;
            }
            return false;
        }
    }
}
