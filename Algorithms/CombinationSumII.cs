// Source : https://leetcode.com/problems/combination-sum-ii/ 
// Author : codeyu 
// Date : Tuesday, October 25, 2016 11:15:50 PM 

/**********************************************************************************
*
* 
* Given a collection of candidate numbers (C) and a target number (T), find all unique combinations in C where the candidate numbers sums to T.
* 
* 
* Each number in C may only be used once in the combination.
* 
* Note:
* 
* All numbers (including target) will be positive integers.
* The solution set must not contain duplicate combinations.
* 
* 
* 
* 
* For example, given candidate set [10, 1, 2, 7, 6, 1, 5] and target 8, 
* A solution set is: 
* 
* [
*   [1, 7],
*   [1, 2, 5],
*   [2, 6],
*   [1, 1, 6]
* ]
* 
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution040 
    {
        public static IList<IList<int>> CombinationSum2(int[] candidates, int target) 
        {
            IList<IList<int>> result = new List<IList<int>>();
            if(candidates == null || candidates.Length==0)
                return result;
            Array.Sort(candidates);
            helper(candidates, 0, target, new List<int>(), result);
            return result;
            
        }
        private static void helper(int[] candidates, int start, int target, IList<int> item, 
                                    IList<IList<int>> result)
        {
            if(target < 0 || start >= candidates.Length)
                return;
            if(target==0)
            {
                result.Add(new List<int>(item));
                return;
            }
            for(int i=start; i<candidates.Length; i++)
            {
                if(i > start && candidates[i] == candidates[i-1])
                    continue;
                item.Add(candidates[i]);
                helper(candidates, i+1, target-candidates[i], item, result);
                item.RemoveAt(item.Count-1);
            }
        }
    }
}

