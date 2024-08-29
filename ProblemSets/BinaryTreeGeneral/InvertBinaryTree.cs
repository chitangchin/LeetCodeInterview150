using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.BinaryTreeGeneral
{
    public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        public int val = val;
        public TreeNode? left = left;
        public TreeNode? right = right;

        public class InvertBinaryTreeLeet
        {
            public TreeNode InvertTree(TreeNode? root)
            {
                //Base case
                if (root == null) return root;
                //Invert
                (root.right, root.left) = (InvertTree(root.left), InvertTree(root.right));
                return root;
            }
        }
    }
}
