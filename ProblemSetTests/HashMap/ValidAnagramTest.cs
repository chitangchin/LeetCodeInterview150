using ProblemSets.HashMap.ValidAnagram;

namespace ProblemSetTests.HashMap
{
    public class ValidAnagramTest
    {
        [Test]
        public void Test()
        {
            Assert.That(ValidAnagramLeet.IsAnagram("anagram", "nagaram"), Is.True);
            Assert.That(ValidAnagramLeet.IsAnagram("rat", "car"), Is.False);
        }
    }
}
