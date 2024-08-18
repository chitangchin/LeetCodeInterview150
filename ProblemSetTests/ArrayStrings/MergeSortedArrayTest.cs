using ProblemSets.ArrayStrings;

namespace ProblemSetTests.ArrayStrings
{
    [TestFixture]
    public class MergeSortedArrayTest
    {
        [Test]
        public void Test1()
        {
            Assert.That(SolutionClass.Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3), Is.EqualTo(new int[] { 1, 2, 2, 3, 5, 6 }));
        }
        [Test]
        public void TestEmpty()
        {
            Assert.That(SolutionClass.Merge(new int[] { 0 }, 0, new int[] { 1 }, 1), Is.EqualTo(new int[] { 1 }));
        }
        [Test]
        public void TestOneEl()
        {
            Assert.That(SolutionClass.Merge(new int[] { 1 }, 1, new int[] { }, 0), Is.EqualTo(new int[] { 1 }));
        }
    }
}
