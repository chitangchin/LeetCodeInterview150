using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.ArrayStrings.BestTimeToBuyAndSellStockII
{
    public class BestTimeToBuyAndSellStockIILeet
    {
        public static int MaxProfit(int[] prices)
        {
            int result = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] - prices[i - 1] > 0)
                {
                    result += prices[i] - prices[i - 1];
                }
            }
            return result;
        }
    }
}
