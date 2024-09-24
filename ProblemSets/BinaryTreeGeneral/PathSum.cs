using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.BinaryTreeGeneral.PathSum
{
    public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        public int val = val;
        public TreeNode left = left;
        public TreeNode right = right;
    }
    public class PathSumLeet
    {
        public static bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;

            // Stack to hold pairs of (node, cumulative sum)
            Stack<(TreeNode node, int currentSum)> nodeStack = new Stack<(TreeNode, int)>();
            nodeStack.Push((root, root.val));

            while (nodeStack.Count > 0)
            {
                var (node, currentSum) = nodeStack.Pop();

                // If the node is null, skip it
                if (node == null)
                {
                    continue;
                }

                // Check if it's a leaf node
                if (node.left == null && node.right == null)
                {
                    // Check if the cumulative sum equals targetSum
                    if (currentSum == targetSum)
                    {
                        return true;
                    }
                }

                // Push the right child onto the stack with updated sum
                if (node.right != null)
                {
                    nodeStack.Push((node.right, currentSum + node.right.val));
                }

                // Push the left child onto the stack with updated sum
                if (node.left != null)
                {
                    nodeStack.Push((node.left, currentSum + node.left.val));
                }
            }
            return false;
        }
    }
}
