using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.HashMap.IsomorphicString
{
    public class IsomorphicStringLeet
    {
        public static bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;

            Dictionary<char, char> map = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    if (map[s[i]] != t[i]) return false;
                }
                else
                {
                    if (map.ContainsValue(t[i])) return false;
                    map[s[i]] = t[i];
                }
            }
            return true;
        }
    }
}
