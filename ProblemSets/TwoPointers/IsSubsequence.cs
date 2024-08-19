using System.Security.Cryptography.X509Certificates;

namespace ProblemSets.TwoPointers.IsSubsequence
{
    public class SolutionClass
    {
        public static bool IsSubsequence(string s, string t)
        {
            //Divide and Conquere Greedy Approach

            //Initiate left and right bound
            int leftBound = s.Length;
            int rightBound = t.Length;

            //Create a recursive function
            bool rec_isSubsequence(int leftIndex, int rightIndex)
            {
                //Base case
                if (leftIndex == leftBound) return true;
                if (rightIndex == rightBound) return false;

                //Case 1:
                if (s[leftIndex] == t[rightIndex])
                {
                    leftIndex++;
                }
                rightIndex++;

                return rec_isSubsequence(leftIndex, rightIndex);
            }

            return rec_isSubsequence(0,0);
        }
    }
}
