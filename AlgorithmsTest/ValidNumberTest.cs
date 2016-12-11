using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class ValidNumberTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(string s, bool output)
        {
            Assert.Equal(output, Solution065.IsNumber(s));
        }
    }
}

