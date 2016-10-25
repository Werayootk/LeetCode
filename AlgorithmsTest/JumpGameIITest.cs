using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class JumpGameIITest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int[] nums, int output)
        {
            Assert.Equal(output, Solution045.Jump(nums));
        }
    }
}

