using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class RotateListTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(ListNode head, int k, ListNode output)
        {
            Assert.Equal(output, Solution061.RotateRight(head, k));
        }
    }
}

