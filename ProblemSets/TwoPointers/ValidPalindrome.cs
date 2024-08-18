using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.TwoPointers.IsPalindrome
{
    public class SolutionClass
    {
        public static bool IsPalindrome(string s)
        {
            int leftPointer = 0;
            int rightPointer = s.Length - 1;

            while (leftPointer < rightPointer)
            {
                while (leftPointer < rightPointer && !Char.IsLetterOrDigit(s[leftPointer]))
                {
                    leftPointer++;
                }
                while (leftPointer < rightPointer && !Char.IsLetterOrDigit(s[rightPointer]))
                {
                    rightPointer--;
                }
                if (char.ToLower(s[rightPointer]) != char.ToLower(s[leftPointer]))
                {
                    return false;
                }
                leftPointer++;
                rightPointer--;
            }
            return true;
        }
    }
}
