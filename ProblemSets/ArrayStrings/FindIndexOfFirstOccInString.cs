namespace ProblemSets.ArrayStrings.FindIndexOfFirstOccInString
{
    public class SolutionClass
    {
        public static int StrStr(string haystack, string needle)
        {
            //Check the first char in needle
            //check first letter in haystack
            //if equal then move the pointer in needle and haystack
            //if not equal then reset needle pointer and check loop again
            //ssadbutsad
            // |
            //sad
            //|
            int haystackP = 0;
            int needleP = 0;

            while (needleP < needle.Length || haystackP < haystack.Length)
            {
                if (needle[needleP] == haystack[haystackP])
                {
                    needleP++;
                    haystackP++;
                }
                else
                {
                    needleP = 0;
                    if (haystack[haystackP] != needle[needleP]) haystackP++;
                }
            }
            return haystackP - needleP;
        }
    }
}
