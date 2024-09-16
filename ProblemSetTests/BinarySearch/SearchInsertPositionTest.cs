using ProblemSets.BinarySearch.SearchInsertPosition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSetTests.BinarySearch
{
    public class SearchInsertPositionTest
    {
        [Test]
        public void GivenTest()
        {
            Assert.That(SearchInsertPositionLeet.SearchInsert([1, 3, 5, 6], 5), Is.EqualTo(2));
            Assert.That(SearchInsertPositionLeet.SearchInsert([1, 3, 5, 6], 2), Is.EqualTo(1));
            Assert.That(SearchInsertPositionLeet.SearchInsert([1, 3, 5, 6], 7), Is.EqualTo(4));
        }
        [Test]
        public void CustomTest()
        {
            Assert.That(SearchInsertPositionLeet.SearchInsert([1, 2, 3, 4, 5, 6, 7, 8, 9, 10], 7), Is.EqualTo(6));
            Assert.That(SearchInsertPositionLeet.SearchInsert([1, 3, 5, 6, 90, 100, 101, 3000, 4000, 4021], 4021), Is.EqualTo(9));
        }
    }
}
