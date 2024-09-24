using ProblemSets.BinaryTreeGeneral.PathSum;

namespace ProblemSetTests.BinaryTreeGeneral
{
    public class PathSumTest
    {
        [Test]
        public void Test()
        {
            var root = new TreeNode(5,
                            new TreeNode(4,
                                new TreeNode(11,
                                    new TreeNode(7),
                                    new TreeNode(2)
                                    ),
                                null
                                ),
                            new TreeNode(8,
                                new TreeNode(13),
                                new TreeNode(4,
                                    null,
                                    new TreeNode(1)
                                )
                            )
                        );
            Assert.That(PathSumLeet.HasPathSum(root, 22), Is.True);
        }
    }
}
