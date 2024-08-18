using ProblemSets._1Fundamentals.BinaryToDecimal;

namespace ProblemSetTests._1Fundamentals
{
    public class BinaryToDecimalTests
    {
        [Test]
        public void Tests1()
        {
            Assert.That(SolutionClass.BinaryToDecimal("10"), Is.EqualTo(2));
            Assert.That(SolutionClass.BinaryToDecimal("1111011"), Is.EqualTo(123));
            Assert.That(SolutionClass.BinaryToDecimal("11010101"), Is.EqualTo(213));
            Assert.That(SolutionClass.BinaryToDecimal("111100"), Is.EqualTo(60));
        }
    }
}
