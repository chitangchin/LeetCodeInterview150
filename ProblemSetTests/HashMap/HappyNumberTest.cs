using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSets.HashMap.HappyNumber;

namespace ProblemSetTests.HashMap
{
    public class HappyNumberTest
    {
        [Test]
        public void Test()
        {
            Assert.That(HappyNumberLeet.IsHappy(19), Is.True);
            Assert.That(HappyNumberLeet.IsHappy(2), Is.False);
        }
    }
}
