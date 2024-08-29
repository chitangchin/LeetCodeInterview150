namespace ProblemSets.ArrayStrings.FindIndexOfFirstOccInString
{
    public class SolutionClass
    {
        public static int StrStr(string haystack, string needle)
        {
            if (haystack.Length < needle.Length) return -1;
            if (haystack == needle) return 0;
            int windowSize = needle.Length;
            for (int i = 0; i <= haystack.Length - windowSize; i++)
            {
                if (haystack[i..(i + windowSize)].ToString() == needle)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
