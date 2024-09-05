using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSets.ArrayStrings.HIndex;

namespace ProblemSetTests.ArrayStrings
{
    public class HIndexTest
    {
        [Test]
        public void Test()
        {
            Assert.That(HIndexLeet.HIndex([3, 0, 6, 1, 5]), Is.EqualTo(3));
            Assert.That(HIndexLeet.HIndex([1, 3, 1]), Is.EqualTo(1));
            Assert.That(HIndexLeet.HIndex([0, 0, 4, 4]), Is.EqualTo(2));
            Assert.That(HIndexLeet.HIndex([1, 2, 2, 3]), Is.EqualTo(2));
        }
    }
}
