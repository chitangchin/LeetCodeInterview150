using ProblemSets.ArrayStrings.LongestCommonPrefix;
namespace ProblemSetTests.ArrayStrings
{
    public class LongestCommonPrefixTest
    {
        [Test]
        public void Test()
        {
            Assert.That(SolutionClass.LongestCommonPrefix(["flower", "flow", "flight"]), Is.EqualTo("fl"
));
            Assert.That(SolutionClass.LongestCommonPrefix(["dog", "racecar", "car"]), Is.EqualTo(""));
        }
    }
}
