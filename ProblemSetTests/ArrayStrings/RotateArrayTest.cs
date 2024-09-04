using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSets.ArrayStrings.RotateArray;

namespace ProblemSetTests.ArrayStrings
{
    public class RotateArrayTest
    {
        private readonly int[] expected = [5, 6, 7, 1, 2, 3, 4];
        private readonly int[] expected2 = [3, 99, -1, -100];
        [Test]
        public void Test()
        {
            Assert.That(RotateLeet.Rotate([1, 2, 3, 4, 5, 6, 7], 3), Is.EqualTo(expected));
            Assert.That(RotateLeet.Rotate([-1, -100, 3, 99], 2), Is.EqualTo(expected2));
        }
    }
}
