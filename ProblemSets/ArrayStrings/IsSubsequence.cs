namespace ProblemSets.ArrayStrings.IsSubsequence
{
    public class SolutionClass
    {
        public static bool IsSubsequence(string s, string t)
        {
            if (s.Length == 0 || s == null) return true;
            //Two pointer solution
            int pointerS = 0;
            int pointerT = 0;

            //consists of lowercase english letters
            //If does not exist then return false;
            //If exists then return true;

            while (pointerS < s.Length && pointerT < t.Length)
            {
                if (pointerS != s.Length && pointerT != t.Length)
                {
                    if (s[pointerS] == t[pointerT])
                    {
                        pointerS++;
                    }
                    pointerT++;
                }
                if (pointerS == s.Length) return true;
            }
            return false;
        }
    }
}
