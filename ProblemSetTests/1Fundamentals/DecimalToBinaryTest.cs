namespace ProblemSetTests._1Fundamentals
{
    using ProblemSets._1Fundamentals.DecimalToBinary;
    public class DecimalToBinaryTests
    {
        [Test]
        public void Test1()
        {
            Assert.That(SolutionClass.ToBinary(2), Is.EqualTo("10"));
        }
    }
}
