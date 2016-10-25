using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class RotateImageTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int[,] matrix, int[,] output)
        {
            Assert.Equal(output, Solution048.Rotate(matrix));
        }
    }
}

