using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class MinimumPathSumTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int[,] grid, int output)
        {
            Assert.Equal(output, Solution064.MinPathSum(gird));
        }
    }
}

