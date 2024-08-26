using ProblemSets.ArrayStrings.MajorityElement; 

namespace ProblemSetTests.ArrayStrings
{
    public class MajorityElementTest
    {
        [Test]
        public void Test()
        {
            Assert.That(SolutionClass.MajorityElement([3, 2, 3]), Is.EqualTo(3));
            Assert.That(SolutionClass.MajorityElement([2, 2, 1, 1, 1]), Is.EqualTo(1));
        }
    }
}
