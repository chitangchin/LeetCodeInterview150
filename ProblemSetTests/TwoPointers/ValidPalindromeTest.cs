using ProblemSets.TwoPointers.IsPalindrome;

namespace ProblemSetTests.TwoPointers
{
    public class ValidPalindromeTest
    {
        [Test]
        public void Test1()
        {
            Assert.That(SolutionClass.IsPalindrome("A man, a plan, a canal: Panama"), Is.EqualTo(true));
        }
        [Test]
        public void Test2()
        {
            Assert.That(SolutionClass.IsPalindrome("race a car"), Is.EqualTo(false));
        }
        [Test]
        public void TestEmptyInput()
        {
            Assert.That(SolutionClass.IsPalindrome(" "), Is.EqualTo(true));
        }
    }
}
