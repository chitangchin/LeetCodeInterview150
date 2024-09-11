using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.TwoPointers.TwoSumII
{
    public class TwoSumIILeet
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            if (numbers.Length == 2) return [1, 2];

            int endPointer = numbers.Length - 1;
            int startPointer = 0;

            while (startPointer < endPointer)
            {
                int totalSum = numbers[startPointer] + numbers[endPointer];

                if (totalSum == target)
                {
                    return new int[] { startPointer + 1, endPointer + 1 };
                }
                else if (totalSum < target)
                {
                    ++startPointer;
                }
                else
                {
                    --endPointer;
                }
            }
            return new int[] { -1, -1 };
        }
    }
}
