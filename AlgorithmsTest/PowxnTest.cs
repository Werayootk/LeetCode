using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class PowxnTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(double x, int n, double output)
        {
            Assert.Equal(output, Solution050.MyPow(x, n));
        }
    }
}

