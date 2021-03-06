// Source : https://leetcode.com/problems/divide-two-ints/ 
// Author : codeyu 
// Date : 2016年10月14日 17:11:21 

/**********************************************************************************
*
* 
* Divide two ints without using multiplication, division and mod operator.
* 
* 
* If it is overflow, return MAX_INT.
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution029 
    {
        public static int Divide(int dividend, int divisor) 
        {
            //handle special cases
            if(divisor==0) return int.MaxValue;
            if(divisor==-1 && dividend == int.MinValue)
                return int.MaxValue;
        
            //get positive values
            long pDividend = Math.Abs((long)dividend);
            long pDivisor = Math.Abs((long)divisor);
        
            int result = 0;
            while(pDividend>=pDivisor){
                //calculate number of left shifts
                int numShift = 0;    
                while(pDividend>=(pDivisor<<numShift)){
                    numShift++;
                }
        
                //dividend minus the largest shifted divisor
                result += 1<<(numShift-1);
                pDividend -= (pDivisor<<(numShift-1));
            }
        
            if((dividend>0 && divisor>0) || (dividend<0 && divisor<0)){
                return result;
            }else{
                return -result;
            } 
        }
    }
}

