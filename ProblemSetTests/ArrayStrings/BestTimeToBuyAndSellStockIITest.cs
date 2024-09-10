using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSets.ArrayStrings.BestTimeToBuyAndSellStockII;

namespace ProblemSetTests.ArrayStrings
{
    public class BestTimeToBuyAndSellStockIITest
    {
        [Test]
        public void Test()
        {
            Assert.That(BestTimeToBuyAndSellStockIILeet.MaxProfit([7, 1, 5, 3, 6, 4]), Is.EqualTo(7));
            Assert.That(BestTimeToBuyAndSellStockIILeet.MaxProfit([1, 2, 3, 4, 5]), Is.EqualTo(4));
            Assert.That(BestTimeToBuyAndSellStockIILeet.MaxProfit([7, 6, 4, 3, 1]), Is.EqualTo(0));
        }
    }
}
