using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.ArrayStrings.GasStation
{
    public class GasStationLeet
    {
        public static int CanCompleteCircuit(int[] gas, int[] cost)
        {
            if (gas.Sum() < cost.Sum()) return -1; //if this condition is false then we have a solution

            int total = 0;
            int startIndex = 0;
            for (int index = 0; index < gas.Length; index++)
            {
                total += (gas[index] - cost[index]);
                //Console.WriteLine($"Index: {index}");
                //Console.WriteLine($"Total: {total}\n");
                if (total < 0)
                {
                    //Console.WriteLine("reset total to 0");
                    // when difference is negative, then we have to start again
                    total = 0;
                    startIndex = index + 1;
                    //Console.WriteLine($"Start Index: {startIndex}\n");
                }
            }
            return startIndex;
        }
    }
}
