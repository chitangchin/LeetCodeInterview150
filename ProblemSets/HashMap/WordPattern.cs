namespace ProblemSets.HashMap.WordPattern
{
    public class WordPatternLeet
    {
        public static bool WordPattern(string pattern, string s)
        {
            Dictionary<char, string> hashMap = new Dictionary<char, string?>();
            string[] resultArr = s.Split(" ");

            if (resultArr.Length != pattern.Length)
            {
                return false;
            }


            for (int i = 0; i < pattern.Length; i++)
            {
                if (hashMap.ContainsKey(pattern[i]))
                {
                    if (hashMap[pattern[i]] != resultArr[i]) return false;
                }
                else
                {
                    if (hashMap.ContainsValue(resultArr[i])) return false;
                    hashMap[pattern[i]] = resultArr[i];
                }
            }
            return true;
        }
    }
}
