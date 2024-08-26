using System.Diagnostics.Metrics;

namespace ProblemSets.ArrayStrings.MajorityElement
{
    public class SolutionClass
    {
        public static int MajorityElement(int[] nums)
        {
            //Given array nums of size n return majority element
            //An element that appears more than 1 time
            //Assume majority element always appears

            //hashmap approach
            //Dictionary<int, int> map = new Dictionary<int, int>();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (map.ContainsKey(nums[i])) map[nums[i]] += 1;
            //    else
            //    {
            //        map[nums[i]] = 1;

            //    }
            //}
            //int currentMaxEl = 0;
            //int currentMaxApper = 0;

            //foreach (KeyValuePair<int, int> pair in map)
            //{
            //    if (pair.Value > currentMaxApper)
            //    {
            //        currentMaxApper = pair.Value;
            //        currentMaxEl = pair.Key;
            //    }
            //}
            //return currentMaxEl;

            //Boyer-Moore Algorithm
            //When we see the same element we add 1 if we dont we subtract 1 and at 0 we reset the current majority el to new el

            int count = 0;
            int candidate = nums[0];

            foreach(int num in nums)
            {
                if (count == 0)
                {
                    candidate = num;
                }
                count += (num == candidate) ? 1 : -1;
            }
            return candidate;
        }
    }
}
