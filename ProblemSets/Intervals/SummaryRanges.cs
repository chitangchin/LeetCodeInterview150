namespace ProblemSets.Intervals.SummaryRanges
{
    public class SolutionClass
    {
        public static IList<string> SummaryRanges(int[] nums)
        {
            //Given sorted unique integers \
            /*
            How to tell if range is increasing:
            iterate through nums?
            */
            //Declare a string List result and initialize it to the new instance of a string List
            IList<string> result = new List<string>();

            //Edge case
            if (nums.Length == 0) return result;
            if (nums.Length == 1)
            {
                result.Add(nums[0].ToString());
                return result;
            }
            int slowPointer = 0;
            while (slowPointer < nums.Length)
            {
                int range = 1;
                while (slowPointer + range < nums.Length && nums[slowPointer] + range == nums[slowPointer + range])
                {
                    range++;
                }
                string rangeResult = "";
                int check = slowPointer;
                rangeResult += $"{nums[slowPointer]}";
                slowPointer += range;
                if (check != slowPointer - 1)
                {
                    rangeResult += $"->{nums[slowPointer - 1]}";
                }
                result.Add(rangeResult);
            }
            return result;
        }
    }
}
