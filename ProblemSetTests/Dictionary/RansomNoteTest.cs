using ProblemSets.Dictionary.Ransom;

namespace ProblemSetTests.Dictionary
{
    public class RansomNoteTest
    {
        [Test]
        public void Test()
        {
            Assert.That(SolutionClass.CanConstruct("a", "b"), Is.False);
        }
        [Test]
        public void Test1()
        {
            Assert.That(SolutionClass.CanConstruct("aa", "ab"), Is.False);
        }
        [Test]
        public void Test2()
        {
            Assert.That(SolutionClass.CanConstruct("aa", "aab"), Is.True);
        }
    }
}
