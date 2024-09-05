using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSets.ArrayStrings.ReverseWordsInString;

namespace ProblemSetTests.ArrayStrings
{
    public class ReverseWordsInStringTest
    {
        [Test]
        public void Test()
        {
            Assert.That(ReverseWordsInStringLeet.ReverseWords("the sky is blue"), Is.EqualTo("blue is sky the"));
            Assert.That(ReverseWordsInStringLeet.ReverseWords("  hello world  "), Is.EqualTo("world hello"));
            Assert.That(ReverseWordsInStringLeet.ReverseWords("a good   example"), Is.EqualTo("example good a"));
        }
    }
}
