namespace ProblemSets.ArrayStrings.LongestCommonPrefix
{
    public class SolutionClass
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            //Edge case check
            if (strs == null || strs.Length == 0)
                return "";
            //Iterate through the string
            for (int i = 0; i < strs[0].Length; i++)
            {
                //Store the first character of the first word
                char c = strs[0][i];
                //Iterate through the rest of the words
                for (int j = 1; j < strs.Length; j++)
                {
                    //Check if i == the length of the other word or the word[i] != c
                    if (i == strs[j].Length || strs[j][i] != c)
                        return strs[0].Substring(0, i);
                    //if c exists in all the other words then i will increment and check the next letter strs[0][i+1].. until str[0][i] does not match a character in one of the words or until we find our the index is equal to a words length.
                }
            }
            //This is for edge case of a string having more than length 0 but an empty string ""
            return strs[0];
        }
    }
}
