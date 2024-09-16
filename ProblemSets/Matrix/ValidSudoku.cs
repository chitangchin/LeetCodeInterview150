using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.Matrix.ValidSudoku
{
    public class ValidSudokuLeet
    {
        public static bool IsValidSudoku(char[][] board)
        {
            int N = 9;
            // Use hash set to record the status
            HashSet<char>[] rows = new HashSet<char>[N];
            HashSet<char>[] cols = new HashSet<char>[N];
            HashSet<char>[] boxes = new HashSet<char>[N];
            for (int r = 0; r < N; r++)
            {
                rows[r] = new HashSet<char>();
                cols[r] = new HashSet<char>();
                boxes[r] = new HashSet<char>();
            }

            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < N; c++)
                {
                    char val = board[r][c];
                    // Check if the position is filled with number
                    if (val == '.')
                    {
                        continue;
                    }

                    // Check the row
                    if (rows[r].Contains(val))
                    {
                        return false;
                    }

                    rows[r].Add(val);
                    // Check the column
                    if (cols[c].Contains(val))
                    {
                        return false;
                    }

                    cols[c].Add(val);
                    // Check the box
                    int idx = (r / 3) * 3 + c / 3;
                    if (boxes[idx].Contains(val))
                    {
                        return false;
                    }

                    boxes[idx].Add(val);
                }
            }

            return true;
        }
    }
}
