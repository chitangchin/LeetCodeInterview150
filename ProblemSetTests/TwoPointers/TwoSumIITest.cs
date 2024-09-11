using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSets.TwoPointers.TwoSumII;

namespace ProblemSetTests.TwoPointers
{
    public class TwoSumIITest
    {
        private readonly int[] expected = [1, 2];
        private readonly int[] expected2 = [1, 3];
        private readonly int[] expected3 = [1, 2];
        [Test]
        public void GivenTest()
        {
            Assert.That(TwoSumIILeet.TwoSum([2, 7, 11, 15], 9), Is.EqualTo(expected));
            Assert.That(TwoSumIILeet.TwoSum([2, 3, 4], 6), Is.EqualTo(expected2));
            Assert.That(TwoSumIILeet.TwoSum([-1, 0], -1), Is.EqualTo(expected3));
        }
        private readonly int[] expected4 = [1, 2];
        private readonly int[] expected5 = [1, 4];
        private readonly int[] expected6 = [3, 5];
        [Test]
        public void CustomTest()
        {
            Assert.That(TwoSumIILeet.TwoSum([-3, 1, 2, 10], -2), Is.EqualTo(expected4));
            Assert.That(TwoSumIILeet.TwoSum([-100, -99, -88, -102, -2, 1, 14], -202), Is.EqualTo(expected5));
            Assert.That(TwoSumIILeet.TwoSum([0, 99, 1999, 100029, 200000], 201999), Is.EqualTo(expected6));
        }
    }
}
