using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.SlidingWindow.LengthOfLongestSubstring
{
    public class LengthOfLongestSubstringLeet
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int result = 0;
            int left = 0;

            for (int right = 1; right <= s.Length; right++)
            {
                // Move the left pointer to avoid duplicates
                while (right <= s.Length && ContainsDuplicates(s[left..right]))
                {
                    left++;
                }
                // Update the result with the length of the current valid substring
                result = Math.Max(result, right - left);
            }
            return result;
        }

        public static bool ContainsDuplicates(string substring)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < substring.Length; i++)
            {
                if (map.ContainsKey(substring[i]))
                {
                    // Duplicate found, return true
                    return true;
                }
                else
                {
                    map[substring[i]] = 1;
                }
            }
            // No duplicates found
            return false;
        }
    }
}
