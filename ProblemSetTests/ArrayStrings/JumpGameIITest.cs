using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSets.ArrayStrings.JumpGameII;

namespace ProblemSetTests.ArrayStrings
{
    public class JumpGameIITest
    {
        [Test]
        public void Test()
        {
            Assert.That(JumpGameIILeet.Jump([2, 3, 1, 1, 4]), Is.EqualTo(2));
            Assert.That(JumpGameIILeet.Jump([2, 3, 0, 1, 4]), Is.EqualTo(2));
        }
    }
}
