using ProblemSets.Stack.ValidParen;

namespace ProblemSetTests.Stack
{
    public class ValidParenTest
    {
        [Test]
        public void ValidParenTests() 
        {
            Assert.That(SolutionClass.IsValid(new string("()")), Is.True);
        }
    }
}
