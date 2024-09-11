using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSets.HashMap.ContainsDupII;

namespace ProblemSetTests.HashMap
{
    public class ContainsDupIITest
    {
        [Test]
        public void GivenTest()
        {
            Assert.That(ContainsDupIILeet.ContainsNearbyDuplicate([1, 2, 3, 1], 3), Is.True);
            Assert.That(ContainsDupIILeet.ContainsNearbyDuplicate([1, 0, 1, 1], 1), Is.True);
            Assert.That(ContainsDupIILeet.ContainsNearbyDuplicate([1, 2, 3, 1, 2, 3], 2), Is.False);
        }
        [Test]
        public void CustomTest()
        {
            Assert.That(ContainsDupIILeet.ContainsNearbyDuplicate([0,100, 10, 100, 100, 200, 100], 3), Is.True);
            Assert.That(ContainsDupIILeet.ContainsNearbyDuplicate([9, 1, 2, 3, 4, 9], 6), Is.True);
            Assert.That(ContainsDupIILeet.ContainsNearbyDuplicate([8, 8, 8, 8, 8], 1), Is.True);
            Assert.That(ContainsDupIILeet.ContainsNearbyDuplicate([8, 9, 10, 11, 8], 1), Is.False);
        }
    }
}
