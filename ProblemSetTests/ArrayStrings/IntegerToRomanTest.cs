using ProblemSets.ArrayStrings.IntegerToRoman;

namespace ProblemSetTests.ArrayStrings
{
    public class IntegerToRomanTest
    {
        [Test]
        public void Test()
        {
            Assert.That(IntegerToRomanLeet.IntegerToRoman(3749), Is.EqualTo("MMMDCCXLIX"));
            Assert.That(IntegerToRomanLeet.IntegerToRoman(58), Is.EqualTo("LVIII"));
            Assert.That(IntegerToRomanLeet.IntegerToRoman(1994), Is.EqualTo("MCMXCIV"));
        }
    }
}
