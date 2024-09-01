﻿using ProblemSets.Matrix.RotateMatrix;

namespace ProblemSetTests.Matrix
{
    public class RotateMatrixTest
    {
        private readonly static int[][] expected = [[7, 4, 1], [8, 5, 2], [9, 6, 3]];
        private readonly static int[][] expected2 = [[15, 13, 2, 5], [14, 3, 4, 1], [12, 6, 8, 9], [16, 7, 10, 11]];
        [Test]
        public void Test()
        {
            Assert.Multiple(() =>
            {
                Assert.That(RotateMatrixLeet.Rotate([[1, 2, 3], [4, 5, 6], [7, 8, 9]]), Is.EqualTo(expected));
                Assert.That(RotateMatrixLeet.Rotate([[5, 1, 9, 11], [2, 4, 8, 10], [13, 3, 6, 7], [15, 14, 12, 16]]), Is.EqualTo(expected2));
            });
        }
    }
}
