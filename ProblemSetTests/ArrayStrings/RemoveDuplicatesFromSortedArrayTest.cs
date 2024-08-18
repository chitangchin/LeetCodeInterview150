using ProblemSets.ArrayStrings.RemoveDuplicates;

namespace ProblemSetTests.ArrayStrings
{
    public class RemoveDuplicatesFromSortedArrayTest
    {
        [Test]
        public void Test1()
        {
            Assert.That(SolutionClass.RemoveDuplicates(new int[] { 1, 1, 2 }), Is.EqualTo(2));
        }
        [Test]
        public void Test2()
        {
            Assert.That(SolutionClass.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }), Is.EqualTo(5));
        }
    }
}
