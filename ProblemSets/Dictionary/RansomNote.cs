using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.Dictionary.Ransom
{
    public class SolutionClass
    {
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> magazineDictionary = new Dictionary<char, int>();

            for (int i = 0; i < magazine.Length; i++)
            {
                if (!magazineDictionary.ContainsKey(magazine[i]))
                {
                    magazineDictionary.Add(magazine[i], 1);
                }
                else
                {
                    magazineDictionary[magazine[i]]++;
                }
            }

            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (magazineDictionary.ContainsKey(ransomNote[i]) && magazineDictionary[ransomNote[i]] > 0)
                {
                    magazineDictionary[ransomNote[i]]--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
