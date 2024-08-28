using ProblemSets.ArrayStrings.LengthOfLastWord;

namespace ProblemSetTests.ArrayStrings
{
    public class LengthOfLastWordTest
    {
        [Test]
        public void Test()
        {
            Assert.That(SolutionClass.LengthOfLastWord("Hello World"), Is.EqualTo(5));
            Assert.That(SolutionClass.LengthOfLastWord("   fly me   to   the moon  "), Is.EqualTo(4));
            Assert.That(SolutionClass.LengthOfLastWord("luffy is still joyboy"), Is.EqualTo(6));
        }
    }
}
