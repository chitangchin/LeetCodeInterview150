using ProblemSets.ArrayStrings.IsSubsequence;

namespace ProblemSetTests.ArrayStrings
{
    public class IsSubsequenceTest
    {
        [Test]
        public void Test()
        {
            Assert.That(SolutionClass.IsSubsequence("abc", "ahbgdc"), Is.True);
            Assert.That(SolutionClass.IsSubsequence("axc", "ahbgdc"), Is.False);
        }
    }
}
