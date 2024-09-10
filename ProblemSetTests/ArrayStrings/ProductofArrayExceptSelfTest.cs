using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSets.ArrayStrings.ProductofArrayExceptSelf;

namespace ProblemSetTests.ArrayStrings
{
    public class ProductofArrayExceptSelfTest
    {
        private readonly int[] expected = [24, 12, 8, 6];
        private readonly int[] expected2 = [2, 1];
        private readonly int[] expected3 = [5040, 2520, 1680, 1260, 1008, 840, 720];
        [Test]
        public void Test()
        {
            Assert.That(ProductofArrayExceptSelfLeet.ProductExceptSelf([1, 2, 3, 4]), Is.EqualTo(expected));
        }
        [Test]
        public void TwoElTest()
        {
            Assert.That(ProductofArrayExceptSelfLeet.ProductExceptSelf([1, 2]), Is.EqualTo(expected2));
        }
        [Test]
        public void LargeElTest()
        {
            Assert.That(ProductofArrayExceptSelfLeet.ProductExceptSelf([1, 2, 3, 4, 5, 6, 7]), Is.EqualTo(expected3));
        }
    }
}
