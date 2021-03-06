using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class SubsetsTest
    {
        [Theory]
        [MemberDataAttribute(nameof(InlineData))]
        public void TestMethod(int[] nums, IList<IList<int>> output)
        {
            Assert.Equal(output, Solution078.Subsets(nums));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                int[] nums = new []{1, 2, 3};
                IList<IList<int>> output = new List<IList<int>>() {
                    new List<int> { 3 },
                    new List<int> { 1 },
                    new List<int> { 2 },
                    new List<int> { 1, 2, 3 },
                    new List<int> { 1, 3 },
                    new List<int> { 2, 3 },
                    new List<int> { 1, 2 },
                    new List<int> {},
                };
                driverData.Add(new object[] { nums,output });
                
                return driverData;
            }
        } 
    }
}

