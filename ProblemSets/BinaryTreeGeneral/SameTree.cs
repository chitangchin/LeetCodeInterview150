using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.BinaryTreeGeneral.SameTree
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
    public class SameTreeLeet
    {
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            Stack<TreeNode> pStack = new Stack<TreeNode>();
            Stack<TreeNode> qStack = new Stack<TreeNode>();

            pStack.Push(p);
            qStack.Push(q);

            while (pStack.Count > 0 && qStack.Count > 0)
            {
                TreeNode pNode = pStack.Pop();
                TreeNode qNode = qStack.Pop();

                if (pNode == null && qNode == null)
                {
                    continue;
                }
                else if (pNode == null || qNode == null || pNode.val != qNode.val)
                {
                    return false;
                }

                pStack.Push(pNode.left);
                qStack.Push(qNode.left);
                pStack.Push(pNode.right);
                qStack.Push(qNode.right);
            }
            return pStack.Count == 0 && qStack.Count == 0;
        }
    }
}
