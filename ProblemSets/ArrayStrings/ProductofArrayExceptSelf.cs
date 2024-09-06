using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.ArrayStrings.ProductofArrayExceptSelf
{
    public class ProductofArrayExceptSelfLeet
    {
        public static int[] ProductExceptSelf(int[] nums)
        {

            int productSum = 1;
            int productZeroSum = 1;
            int zeroCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    productZeroSum *= nums[i];
                }
                else
                {
                    zeroCount++;
                }
                productSum *= nums[i];
            }
            int[] resultArray = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0) resultArray[i] = productSum / nums[i];
                else
                {
                    if (zeroCount == 1) resultArray[i] = productZeroSum;
                    else
                    {
                        resultArray[i] = 0;
                    }
                }
            }
            return resultArray;
        }
    }
}
