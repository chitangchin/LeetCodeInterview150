using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.BinarySearch.Search2DMatrix
{
    public static class Search2DMatrixLeet
    {
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int row = BinarySearchColumn(matrix, target);
            if (row == -1)
            {
                return false;
            }
            return BinarySearchRow(matrix[row], target);
        }

        public static int BinarySearchColumn(int[][] matrix, int target)
        {
            int startPointer = 0, endPointer = matrix.Length - 1;

            while (startPointer <= endPointer)
            {
                int midPointer = startPointer + (endPointer - startPointer) / 2;
                int rowFirst = matrix[midPointer][0];
                int rowLast = matrix[midPointer][matrix[midPointer].Length - 1];

                if (target >= rowFirst && target <= rowLast)
                {
                    // Target could be in this row
                    return midPointer;
                }
                else if (target < rowFirst)
                {
                    // Target is in a row above
                    endPointer = midPointer - 1;
                }
                else
                {
                    // Target is in a row below
                    startPointer = midPointer + 1;
                }
            }

            // Target is not present in any row
            return -1;
        }

        public static bool BinarySearchRow(int[] row, int target)
        {
            int startPointer = 0, endPointer = row.Length - 1;

            while (startPointer <= endPointer)
            {
                int midPointer = startPointer + (endPointer - startPointer) / 2;
                if (row[midPointer] < target)
                {
                    startPointer = midPointer + 1;
                }
                else if (row[midPointer] > target)
                {
                    endPointer = midPointer - 1;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
