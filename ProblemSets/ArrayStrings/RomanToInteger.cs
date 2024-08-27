namespace ProblemSets.ArrayStrings.RomanToInteger
{
    public class SolutionClass
    {
        static Dictionary<string, int> values = new Dictionary<string, int> 
        {
            { "I", 1 },   { "V", 5 },    { "X", 10 },  { "L", 50 }, { "C", 100 },
            { "D", 500 }, { "M", 1000 }, { "IV", 4 },  { "IX", 9 }, { "XL", 40 },
            { "XC", 90 }, { "CD", 400 }, { "CM", 900 }
        };
        public static int RomanToInteger(string s)
        {
            int sum = 0;
            int i = 0;
            while (i < s.Length)
            {
                if (i < s.Length - 1)
                {
                    string doubleSymbol = s.Substring(i, 2);
                    if (values.ContainsKey(doubleSymbol))
                    {
                        sum += values[doubleSymbol];
                        i += 2;
                        continue;
                    }
                }

                string singleSymbol = s.Substring(i, 1);
                sum += values[singleSymbol];
                i += 1;
            }

            return sum;
        }
    }
}
