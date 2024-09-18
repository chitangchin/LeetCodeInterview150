using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSets.TwoPointers.BackspaceStringCompare;

namespace ProblemSetTests.TwoPointers
{
    public class BackspaceStringCompareTest
    {
        [Test]
        public void Test()
        {
            Assert.That(BackspaceStringCompareLeet.BackspaceCompare("ab#c", "ad#c"), Is.True);
            Assert.That(BackspaceStringCompareLeet.BackspaceCompare("ab##", "c#d#"), Is.True);
            Assert.That(BackspaceStringCompareLeet.BackspaceCompare("a#c", "b"), Is.False);
        }
    }
}
