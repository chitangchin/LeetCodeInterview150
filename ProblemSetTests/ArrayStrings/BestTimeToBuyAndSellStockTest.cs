using ProblemSets.ArrayStrings.BestTimeToBuyAndSellStock;

namespace ProblemSetTests.ArrayStrings
{
    public class BestTimeToBuyAndSellStockTest
    {
        [Test]
        public void Test()
        {
            Assert.That(SolutionClass.MaxProfit([7, 1, 5, 3, 6, 4]), Is.EqualTo(5));
            Assert.That(SolutionClass.MaxProfit([7, 6, 4, 3, 1]), Is.EqualTo(0));
        }
    }
}
