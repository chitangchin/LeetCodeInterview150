using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.ArrayStrings.ReverseWordsInString
{
    public class ReverseWordsInStringLeet
    {
        public static string ReverseWords(string s)
        {
            Stack<string> words = new Stack<string>();

            string output = "";
            string wordBuilder = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    wordBuilder += s[i];
                }
                else
                {
                    if (wordBuilder.Length > 0)
                    {
                        words.Push(wordBuilder);
                        wordBuilder = "";
                    }
                }
            }

            if (wordBuilder.Length > 0)
            {
                words.Push(wordBuilder);
            }

            while (words.Count > 0)
            {
                output += words.Pop();

                if (words.Count > 0)
                {
                    output += " ";
                }
            }
            return output;
        }
    }
}
