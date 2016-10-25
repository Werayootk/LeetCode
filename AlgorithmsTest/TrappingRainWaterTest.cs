using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class TrappingRainWaterTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int[] height, int output)
        {
            Assert.Equal(output, Solution042.Trap(height));
        }
    }
}

