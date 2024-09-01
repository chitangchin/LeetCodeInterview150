using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.Matrix.RotateMatrix
{
    public class RotateMatrixLeet
    {
        public static int[][] Rotate(int[][] matrix)
        {
            int n = matrix.Length;
            Transpose(matrix, n);
            Reflect(matrix, n);
            return matrix;
        }

        private static void Transpose(int[][] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int temp = matrix[j][i];
                    matrix[j][i] = matrix[i][j];
                    matrix[i][j] = temp;
                }
            }
        }

        private static void Reflect(int[][] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[i][n - j - 1];
                    matrix[i][n - j - 1] = temp;
                }
            }
        }
    }
}
