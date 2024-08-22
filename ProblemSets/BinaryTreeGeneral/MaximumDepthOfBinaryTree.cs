namespace ProblemSets.BinaryTreeGeneral.MaxDepth
{
    public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        public int val = val;
        public TreeNode left = left;
        public TreeNode right = right;
    }

    public class SolutionClass
    {
        public static int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            //define a var variable named stack and initialize it to the instance of a Stack with the element type of (TreeNode, int)
            Stack<(TreeNode, int)> stack = new Stack<(TreeNode, int)>();

            //Push the root with a value 1 representing the depth at that node
            stack.Push((root, 1));

            //Initialize an integer variable depth and assign it to the value 0
            int depth = 0;

            //Iterate thorugh stack, while stack is not empty
            while (stack.Count != 0)
            {
                //We will pop the top most node from the stack
                (TreeNode, int) current = stack.Pop();
                //Check if the height of the node is larger than the current depth
                depth = Math.Max(depth, current.Item2);
                //If the nodes are not leaf nodes then we can add its children nodes to the stack for us to inspect them.
                if (current.Item1.left != null) stack.Push((current.Item1.left, current.Item2 + 1));
                if (current.Item1.right != null) stack.Push((current.Item1.right, current.Item2 + 1));

                //Once we hit the leaf nodes, it will not push anymore nodes and eventually be empty breaking the while loop
            }

            //Integer depth
            return depth;

        }
    }
}
