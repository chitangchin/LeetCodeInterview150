using ProblemSets.HashMap.IsomorphicString;

namespace ProblemSetTests.HashMap
{
    public class IsomorphicStringTest
    {
        [Test]
        public void Test()
        {
            Assert.That(IsomorphicStringLeet.IsIsomorphic("egg", "add"), Is.True);
            Assert.That(IsomorphicStringLeet.IsIsomorphic("foo", "bar"), Is.False);
            Assert.That(IsomorphicStringLeet.IsIsomorphic("paper", "title"), Is.True);
        }
    }
}
