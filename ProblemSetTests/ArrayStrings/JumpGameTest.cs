using ProblemSets.ArrayStrings.JumpGameII;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSets.ArrayStrings.JumpGame;

namespace ProblemSetTests.ArrayStrings
{
    public class JumpGameTest
    {
        [Test]
        public void Test()
        {
            Assert.That(JumpGameLeet.CanJump([2, 3, 1, 1, 4]), Is.True);
            Assert.That(JumpGameLeet.CanJump([3, 2, 1, 0, 4]), Is.False);
        }
    }
}
