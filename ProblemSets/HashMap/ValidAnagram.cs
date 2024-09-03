using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.HashMap.ValidAnagram
{
    public class ValidAnagramLeet
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            Dictionary<char, int> map = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i])) map[s[i]] += 1;
                else
                {
                    map[s[i]] = 1;
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (map.ContainsKey(t[i]))
                {
                    map[t[i]] -= 1;
                    if (map[t[i]] == 0) map.Remove(t[i]);
                }
                else
                {
                    return false;
                }
            }

            if (map.Count != 0) return false;
            return true;
        }
    }
}
