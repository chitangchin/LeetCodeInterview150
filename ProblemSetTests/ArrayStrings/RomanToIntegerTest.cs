using ProblemSets.ArrayStrings.RomanToInteger;

namespace ProblemSetTests.ArrayStrings
{
    public class RomanToIntegerTest
    {
        [Test]
        public void Test()
        {
            Assert.That(SolutionClass.RomanToInteger("III"), Is.EqualTo(3));
            Assert.That(SolutionClass.RomanToInteger("LVIII"), Is.EqualTo(58));
            Assert.That(SolutionClass.RomanToInteger("MCMXCIV"), Is.EqualTo(1994));
        }
    }
}
