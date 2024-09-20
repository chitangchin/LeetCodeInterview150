using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.BinarySearch.SearchInsertPosition
{
    public class SearchInsertPositionLeet
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int startPointer = 0, endPointer = nums.Length - 1, midPointer;
            while (startPointer <= endPointer)
            {
                midPointer = startPointer + (endPointer - startPointer) / 2;
                if (nums[midPointer] < target)
                {
                    startPointer = midPointer + 1;
                }
                else if (nums[midPointer] > target)
                {
                    endPointer = midPointer - 1;
                }
                else
                {
                    return midPointer;
                }
            }
            return startPointer;
        }
    }
}

