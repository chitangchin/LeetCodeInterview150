using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSets.ArrayStrings.GasStation;

namespace ProblemSetTests.ArrayStrings
{
    public class GasStationTest
    {
        [Test]
        public void Test()
        {
            Assert.That(GasStationLeet.CanCompleteCircuit([1, 2, 3, 4, 5], [3, 4, 5, 1, 2]), Is.EqualTo(3));
            Assert.That(GasStationLeet.CanCompleteCircuit([2, 3, 4], [3, 4, 3]), Is.EqualTo(-1));
        }
    }
}
