using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class NextPermutationTest
    {
        [Theory]
        [InlineData(new []{1,2,3})]
        public void TestMethod(int[] nums)
        {
            var result = false;
            try
            {
                Solution031.NextPermutation(nums);
                result = true;
            }
            catch
            {
                result = false;
            }
            
            Assert.True(result);
        }
    }
}

