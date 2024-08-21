namespace ProblemSets.Stack.ValidParen
{
    public class SolutionClass
    {
        // Declared a private Dictionary variable called mappings (Encapsulation Pillar for OOP)
        private Dictionary<char, char> mappings;

        public SolutionClass()
        {
            mappings = new Dictionary<char, char> {
            { ')', '(' }, { '}', '{' }, { ']', '[' }
        };
        }

        public static bool IsValid(string s)
        {
            var solutionClass = new SolutionClass();
            var stack = new Stack<char>();
            foreach (var c in s)
            {
                if (solutionClass.mappings.ContainsKey(c))
                {
                    char topElement = stack.Count == 0 ? '#' : stack.Pop();
                    if (topElement != solutionClass.mappings[c])
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }
            return stack.Count == 0;
        }
    }
}
