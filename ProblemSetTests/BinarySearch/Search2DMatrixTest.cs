using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSets.BinarySearch.Search2DMatrix;

namespace ProblemSetTests.BinarySearch
{
    public class Search2DMatrixTest
    {
        [Test]
        public void GivenTest()
        {
            Assert.That(Search2DMatrixLeet.SearchMatrix([[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]], 3), Is.True);
            Assert.That(Search2DMatrixLeet.SearchMatrix([[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]], 13), Is.False);
        }
    }
}
