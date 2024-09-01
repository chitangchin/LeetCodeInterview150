using ProblemSets.HashMap.WordPattern;

namespace ProblemSetTests.HashMap
{
    public class WordPatternTest
    {
        [Test]
        public void Test()
        {
            Assert.That(WordPatternLeet.WordPattern("abba", "dog cat cat dog"), Is.True);
            Assert.That(WordPatternLeet.WordPattern("abba", "dog cat cat fish"), Is.False);
            Assert.That(WordPatternLeet.WordPattern("aaaa", "dog cat cat dog"), Is.False);

        }
    }
}
