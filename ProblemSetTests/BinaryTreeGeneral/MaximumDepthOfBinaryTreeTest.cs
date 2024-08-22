using ProblemSets.BinaryTreeGeneral.MaxDepth;

namespace ProblemSetTests.BinaryTreeGeneral
{
    public class MaximumDepthOfBinaryTreeTest
    {
        [Test]
        public void Test()
        {
            TreeNode root = new TreeNode(3, new TreeNode(9, null, null), new TreeNode(20, new TreeNode(15, null, null), new TreeNode(7, null, null)));
            Assert.That(SolutionClass.MaxDepth(root), Is.EqualTo(3));
        }
    }
}
