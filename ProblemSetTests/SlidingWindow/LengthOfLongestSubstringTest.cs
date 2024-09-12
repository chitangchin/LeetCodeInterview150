using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSets.SlidingWindow.LengthOfLongestSubstring;

namespace ProblemSetTests.SlidingWindow
{
    public class LengthOfLongestSubstringTest
    {
        [Test]
        public void GivenTest()
        {
            Assert.That(LengthOfLongestSubstringLeet.LengthOfLongestSubstring("abcabcbb"), Is.EqualTo(3));
            Assert.That(LengthOfLongestSubstringLeet.LengthOfLongestSubstring("bbbbb"), Is.EqualTo(1));
            Assert.That(LengthOfLongestSubstringLeet.LengthOfLongestSubstring("pwwkew"), Is.EqualTo(3));
        }
        [Test]
        public void CustomTest()
        {
            Assert.That(LengthOfLongestSubstringLeet.LengthOfLongestSubstring("abcdefghijklmnopqrstuvwxyza"), Is.EqualTo(26));
            Assert.That(LengthOfLongestSubstringLeet.LengthOfLongestSubstring("bbbbbppppbbbbbaapppppppsssssllllllllaaaaaaaaaa"), Is.EqualTo(2));
            Assert.That(LengthOfLongestSubstringLeet.LengthOfLongestSubstring("dksamdlamf asdladlaskd wqadsas"), Is.EqualTo(8));
        }
    }
}
