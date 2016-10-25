using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class CombinationSumTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int[] candidates, int target, IList<IList<int>> output)
        {
            Assert.Equal(output, Solution039.CombinationSum(candidates, target));
        }
    }
}

