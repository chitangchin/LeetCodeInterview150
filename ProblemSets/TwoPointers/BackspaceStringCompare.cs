using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.TwoPointers.BackspaceStringCompare
{
    public class BackspaceStringCompareLeet
    {
        public static bool BackspaceCompare(string S, string T)
        {
            int i = S.Length - 1, j = T.Length - 1;
            int skipS = 0, skipT = 0;

            while (i >= 0 || j >= 0)
            {
                while (i >= 0)
                {
                    if (S[i] == '#')
                    {
                        skipS++;
                        i--;
                    }
                    else if (skipS > 0)
                    {
                        skipS--;
                        i--;
                    }
                    else
                    {
                        break;
                    }
                }

                while (j >= 0)
                {
                    if (T[j] == '#')
                    {
                        skipT++;
                        j--;
                    }
                    else if (skipT > 0)
                    {
                        skipT--;
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }

                if (i >= 0 && j >= 0 && S[i] != T[j])
                {
                    return false;
                }

                if ((i >= 0) != (j >= 0))
                {
                    return false;
                }

                i--;
                j--;
            }

            return true;
        }
    }
}
