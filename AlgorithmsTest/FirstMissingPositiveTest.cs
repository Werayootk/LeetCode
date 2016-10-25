using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class FirstMissingPositiveTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int[] nums, int output)
        {
            Assert.Equal(output, Solution041.FirstMissingPositive(nums));
        }
    }
}

