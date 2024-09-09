using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets._1DDP.ClimbingStairs
{
    public class ClimbingStairsLeet
    {
        public static int ClimbStairs(int n)
        {
            //Fibonacci Sequence Pattern 1, 2, 3, 5, 8
            if (n == 1) return 1;

            int first = 1;
            int second = 2;
            for (int i = 3; i <= n; i++)
            {
                int third = first + second;
                first = second;
                second = third;
            }
            return second;
        }
    }
}
