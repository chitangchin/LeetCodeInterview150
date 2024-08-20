using ProblemSets.Intervals.SummaryRanges;

namespace ProblemSetTests.Intervals
{
    [TestFixture]
    public class SummaryRangesTest
    {

        [Test]
        public void Test1()
        {
            var list = new List<string> { "0->2", "4->5", "7" };
            Assert.That(SolutionClass.SummaryRanges(new int[] { 0, 1, 2, 4, 5, 7 }), Is.EqualTo(list));
        }
        [Test]
        public void Test2()
        {
            var list = new List<string> { "0", "2->4", "6", "8->9" };
            Assert.That(SolutionClass.SummaryRanges(new int[] { 0, 2, 3, 4, 6, 8, 9 }), Is.EqualTo(list));
        }
    }
}
