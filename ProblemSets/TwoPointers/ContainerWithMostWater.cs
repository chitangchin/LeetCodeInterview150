using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.TwoPointers.ContainerWithMostWater
{
    public class ContainerWithMostWaterLeet
    {
        public static int MaxArea(int[] height)
        {

            int width = height.Length - 1;
            int endPointer = height.Length - 1;
            int startPointer = 0;

            int maxArea = AreaCalc(height[startPointer], height[endPointer], width);

            while (startPointer < endPointer)
            {
                if (height[startPointer] <= height[endPointer])
                {
                    ++startPointer;
                }
                else
                {
                    --endPointer;
                }
                --width;
                if (AreaCalc(height[startPointer], height[endPointer], width) > maxArea)
                {
                    maxArea = AreaCalc(height[startPointer], height[endPointer], width);
                }
            }
            return maxArea;
        }

        public static int AreaCalc(int start, int end, int width)
        {
            return Math.Min(start, end) * width;
        }
    }
}
