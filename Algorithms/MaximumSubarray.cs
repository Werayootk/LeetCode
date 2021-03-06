// Source : https://leetcode.com/problems/maximum-subarray/ 
// Author : codeyu 
// Date : Friday, November 11, 2016 11:56:19 PM 

/**********************************************************************************
*
* 
* Find the contiguous subarray within an array (containing at least one number) which has the largest sum.
* 
* 
* For example, given the array [-2,1,-3,4,-1,2,1,-5,4],
* the contiguous subarray [4,-1,2,1] has the largest sum = 6.
* 
* 
* click to show more practice.
* 
* More practice:
* 
* If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution053 
    {
        public static int MaxSubArray(int[] nums) 
        {
            if(nums==null || nums.Length==0)  
                return 0;  
            int global = nums[0];  
            int local = nums[0];  
            for(int i=1;i<nums.Length;i++)  
            {  
                local = Math.Max(nums[i],local+nums[i]);  
                global = Math.Max(local,global);  
            }  
            return global; 
        }
    }
}

