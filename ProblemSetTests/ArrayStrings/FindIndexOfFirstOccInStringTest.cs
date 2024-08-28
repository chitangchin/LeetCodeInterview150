using ProblemSets.ArrayStrings.FindIndexOfFirstOccInString;

namespace ProblemSetTests.ArrayStrings
{
    public class FindIndexOfFirstOccInStringTest
    {
        //[Test] stil solving
        public void Test()
        {
            Assert.That(SolutionClass.StrStr("sadbutsad", "sad"), Is.EqualTo(0));
            Assert.That(SolutionClass.StrStr("leetcode", "leeto"), Is.EqualTo(-1));
        }
    }
}
