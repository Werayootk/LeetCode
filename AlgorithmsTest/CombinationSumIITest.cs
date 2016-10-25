using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class CombinationSumIITest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int[] candidates, int target, IList<IList<int>> output)
        {
            Assert.Equal(output, Solution040.CombinationSum2(candidates, target));
        }
    }
}

