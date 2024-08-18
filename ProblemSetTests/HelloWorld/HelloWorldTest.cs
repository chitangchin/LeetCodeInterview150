namespace ProblemSetTests.HelloWorldTest
{
    using ProblemSets.HelloWorld;
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            Assert.That(SolutionClass.HelloWorld("Hi!"), Is.EqualTo("Hi!"));
        }
    }
}