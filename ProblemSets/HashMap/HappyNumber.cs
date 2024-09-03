using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.HashMap.HappyNumber
{
    public class HappyNumberLeet
    {
        public static int getNext(int n)
        {
            int totalSum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                n = n / 10;
                totalSum += digit * digit;
            }
            return totalSum;
        }

        public static bool IsHappy(int n)
        {
            //Slow and fast pointer to identify cycle
            int slowPointer = n;
            int fastPointer = getNext(n);
            while (fastPointer != 1 && slowPointer != fastPointer)
            {
                slowPointer = getNext(slowPointer);
                fastPointer = getNext(getNext(fastPointer));
            }
            return fastPointer == 1;
        }
    }
}
