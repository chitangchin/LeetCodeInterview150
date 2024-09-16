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
            int leftPointer = 0, rightPointer = nums.Length - 1, midPointer;
            while (leftPointer <= rightPointer)
            {
                midPointer = (rightPointer + leftPointer) / 2;
                if (nums[midPointer] < target) leftPointer = midPointer + 1;
                else if (nums[midPointer] > target) rightPointer = midPointer - 1;
                else return midPointer;
            }
            return leftPointer;
        }
    }
}
