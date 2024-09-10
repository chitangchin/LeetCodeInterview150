using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSets.ArrayStrings.RemoveDuplicatesFromSortedArrayII;

namespace ProblemSetTests.ArrayStrings
{
    public class RemoveDuplicatesFromSortedArrayIITest
    {
        [Test]
        public void Test()
        {
            Assert.That(RemoveDuplicatesFromSortedArrayIILeet.RemoveDuplicates([1, 1, 1, 2, 2, 3]), Is.EqualTo(5));
            Assert.That(RemoveDuplicatesFromSortedArrayIILeet.RemoveDuplicates([0, 0, 1, 1, 1, 1, 2, 3, 3]), Is.EqualTo(7));
        }
    }
}
