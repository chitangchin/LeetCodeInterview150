using ProblemSets._1DDP.ClimbingStairs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSetTests._1DDP
{
    public class ClimbingStairsTest
    {
        [Test]
        public void Test()
        {
            Assert.That(ClimbingStairsLeet.ClimbStairs(2), Is.EqualTo(2));
            Assert.That(ClimbingStairsLeet.ClimbStairs(4), Is.EqualTo(5));
            Assert.That(ClimbingStairsLeet.ClimbStairs(5), Is.EqualTo(8));
        }
    }
}
