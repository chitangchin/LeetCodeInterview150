using ProblemSets.HashMap.TwoSum;

namespace ProblemSetTests.HashMap
{
    public class TwoSumTest
    {
        private readonly int[] expected = [0, 1];
        private readonly int[] expected2 = [1, 2];
        private readonly int[] expected3 = [0, 1];
        [Test]
        public void Test()
        {
            Assert.That(TwoSumLeet.TwoSum([2, 7, 11, 15], 9), Is.EqualTo(expected));
            Assert.That(TwoSumLeet.TwoSum([3, 2, 4], 6), Is.EqualTo(expected2));
            Assert.That(TwoSumLeet.TwoSum([3, 3], 6), Is.EqualTo(expected3));
        }
    }
}
