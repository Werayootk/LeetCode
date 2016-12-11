using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class UniquePathsIITest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int[,] obstacleGrid, int output)
        {
            Assert.Equal(output, Solution063.UniquePathsWithObstacles(obstacleGrid));
        }
    }
}

