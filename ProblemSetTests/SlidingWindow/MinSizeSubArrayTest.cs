using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSets.SlidingWindow.MinSizeSubArray;

namespace ProblemSetTests.SlidingWindow
{
    public class MinSizeSubArrayTest
    {
        [Test]
        public void GivenTest()
        {
            Assert.That(MinSizeSubArrayLeet.MinSubArrayLen(7, [2, 3, 1, 2, 4, 3]), Is.EqualTo(2));
            Assert.That(MinSizeSubArrayLeet.MinSubArrayLen(4, [1, 4, 4]), Is.EqualTo(1));
            Assert.That(MinSizeSubArrayLeet.MinSubArrayLen(11, [1, 1, 1, 1, 1, 1, 1, 1]), Is.EqualTo(0));
        }
        [Test]
        public void CustomTest()
        {
            Assert.That(MinSizeSubArrayLeet.MinSubArrayLen(3921, [523, 1056, 1213, 1624, 1749, 1918, 1985, 2320, 2605, 2763, 2872, 3034, 3193, 3239, 3491, 3938, 3989, 4221, 4441, 4459, 4718, 4854, 5507, 5654, 6078, 6348, 6385, 6570, 6753, 6897, 7319, 7402, 7795, 7981, 8160, 8197, 8435, 8565, 8977, 9012]), Is.EqualTo(1));
            Assert.That(MinSizeSubArrayLeet.MinSubArrayLen(100, [10, 20, 30, 40, 10, 10, 2, 3, 100, 20, 213, 3124, 100, 2999, 1002, 1202, 1010]), Is.EqualTo(1));
            Assert.That(MinSizeSubArrayLeet.MinSubArrayLen(1, [1]), Is.EqualTo(1));
        }
    }
}
