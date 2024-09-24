using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.BinaryTreeGeneral.SymmetricTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class SymmetricTreeLeet
    {
        public static bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;

            Stack<TreeNode> leftStack = new Stack<TreeNode>();
            Stack<TreeNode> rightStack = new Stack<TreeNode>();

            leftStack.Push(root.left);
            rightStack.Push(root.right);

            while (leftStack.Count > 0 && rightStack.Count > 0)
            {
                TreeNode leftNode = leftStack.Pop();
                TreeNode rightNode = rightStack.Pop();

                // If both nodes are null, continue to next iteration
                if (leftNode == null && rightNode == null) continue;

                // If one is null and the other isn't, tree is not symmetric
                if (leftNode == null || rightNode == null) return false;

                // Compare the values of the current nodes
                if (leftNode.val != rightNode.val) return false;

                // Push the children in mirrored order
                leftStack.Push(leftNode.left);
                rightStack.Push(rightNode.right);

                leftStack.Push(leftNode.right);
                rightStack.Push(rightNode.left);
            }

            // If both stacks are empty, the tree is symmetric
            return leftStack.Count == 0 && rightStack.Count == 0;
        }
    }
}
