using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSets.HashMap.GroupAnagram;

namespace ProblemSetTests.HashMap
{
    public class GroupAnagramTest
    {
        private readonly static IList<IList<string>> expected = [["eat", "tea", "ate"], ["tan", "nat"], ["bat"]];
        private readonly static IList<IList<string>> expected2 = [[""]];
        private readonly static IList<IList<string>> expected3 = [["a"]];
        [Test]
        public void GivenTest()
        {
            Assert.That(GroupAnagramLeet.GroupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"]), Is.EqualTo(expected));
            Assert.That(GroupAnagramLeet.GroupAnagrams([""]), Is.EqualTo(expected2));
            Assert.That(GroupAnagramLeet.GroupAnagrams(["a"]), Is.EqualTo(expected3));
        }
    }
}
