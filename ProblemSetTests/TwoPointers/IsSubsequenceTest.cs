using ProblemSets.TwoPointers.IsSubsequence;

namespace ProblemSetTests.TwoPointers
{
    public class IsSubsequenceTest
    {
        [Test]
        public void Test1()
        {
            Assert.That(SolutionClass.IsSubsequence(new string ("abc"), new string("ahbgdc")), Is.True);
        }
        [Test]
        public void Test2()
        {
            Assert.That(SolutionClass.IsSubsequence(new string("axc"), new string("ahbgdc")), Is.False);
        }
    }
}
