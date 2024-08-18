namespace ProblemSets._1Fundamentals.BinaryToDecimal
{
    public class SolutionClass
    {
        public static int BinaryToDecimal(string arg)
        {
            //We can convert the binary to an integer
            int binaryNumber = int.Parse(arg);

            int decimalValue = 0;

            //Initialize base1 value to 1  2^0
            int base1 = 1;

            while (binaryNumber > 0)
            {
                int remainder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalValue += remainder * base1;
                base1 = base1 * 2;
            }
            return decimalValue;
        }
    }
}
