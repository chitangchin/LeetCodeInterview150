namespace ProblemSets.ArrayStrings.LengthOfLastWord
{
    public class SolutionClass
    {
        public static int LengthOfLastWord(string s)
        {
            int endPointer = s.Length, count = 0;
            while (endPointer > 0)
            {
                endPointer--;
                if (s[endPointer] != ' ') count++;
                else if (count > 0) return count;
            }
            return count;
        }
    }
}
