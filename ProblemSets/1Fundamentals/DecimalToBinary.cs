namespace ProblemSets._1Fundamentals.DecimalToBinary
{
    public class SolutionClass
    {
        //Create a recursive function
        public static string ToBinary(int n)
        {
            //Base Case
            if (n < 2) return n.ToString();

            var divisor = n / 2;
            var remainder = n % 2;

            return ToBinary(divisor) + remainder;
        }
    }
}
