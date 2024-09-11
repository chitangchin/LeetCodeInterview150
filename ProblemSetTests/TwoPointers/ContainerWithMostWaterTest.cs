using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSets.TwoPointers.ContainerWithMostWater;

namespace ProblemSetTests.TwoPointers
{
    public class ContainerWithMostWaterTest
    {
        [Test]
        public void GivenTest()
        {
            Assert.That(ContainerWithMostWaterLeet.MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]), Is.EqualTo(49));
            Assert.That(ContainerWithMostWaterLeet.MaxArea([1, 1]), Is.EqualTo(1));
        }
        [Test]
        public void CustomTest()
        {
            Assert.That(ContainerWithMostWaterLeet.MaxArea([5, 6, 11, 14, 17]), Is.EqualTo(22));
            Assert.That(ContainerWithMostWaterLeet.MaxArea([32, 924, 1008, 1198, 1592, 1721, 2013, 3432, 3821, 4453, 6167, 6733, 7014, 7519, 7626, 7726, 8130, 8720, 9045, 9184]), Is.EqualTo(55503));
            Assert.That(ContainerWithMostWaterLeet.MaxArea([30, 41, 59, 90, 222, 310, 477, 484, 756, 818, 830, 999, 1027, 1101, 1245, 1380, 1431, 1509, 1723, 1725, 1785, 1803, 1843, 1877, 2037, 2085, 2130, 2154, 2203, 2227, 2237, 2241, 2339, 2412, 2501, 2551, 2600, 2624, 2903, 2910, 3040, 3136, 3157, 3168, 3311, 3447, 3664, 3810, 3843, 4026, 4063, 4106, 4182, 4275, 4427, 4511, 4639, 4646, 4800, 4839, 4932, 4970, 5280, 5346, 5482, 5495, 5545, 5606, 5798, 5804, 5859, 5979, 6016, 6086, 6098, 6363, 6484, 6562, 6782, 6803, 7414, 7548, 7720, 7825, 7913, 7929, 7980, 8303, 8334, 8338, 8475, 8649, 8667, 8674, 8698, 8701, 8809, 9390, 9650, 9882]), Is.EqualTo(201300));
        }
    }
}
