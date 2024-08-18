using ProblemSets.ArrayStrings.RemoveElement;

namespace ProblemSetTests.ArrayStrings
{
    public class RemoveElementTest
    {
        [Test]
        public void Test1()
        {
            Assert.That(SolutionClass.RemoveElement(new int[] { 3, 2, 2, 3}, 3), Is.EqualTo(2));
        }
    }
}
