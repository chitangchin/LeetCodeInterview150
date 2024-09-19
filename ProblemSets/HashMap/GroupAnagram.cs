using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.HashMap.GroupAnagram
{
    public class GroupAnagramLeet
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            // Create a dictionary with the sorted string as the key
            Dictionary<string, List<string>> hashMap = new Dictionary<string, List<string>>();

            foreach (string str in strs)
            {
                // Sort the characters in the string to create the key
                char[] chars = str.ToCharArray();
                Array.Sort(chars);
                string key = new string(chars);

                // Add the original string to the correct group
                if (hashMap.ContainsKey(key))
                {
                    hashMap[key].Add(str);
                }
                else
                {
                    hashMap[key] = new List<string> { str };
                }
            }

            // Prepare the result
            List<IList<string>> result = new List<IList<string>>();

            foreach (var group in hashMap.Values)
            {
                result.Add(group);
            }

            return result;
        }
    }
}
