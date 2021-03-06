﻿/*
 * Problem 70: Climbing Stairs
 * Difficulty: Easy
 * 
 * You are climbing a stair case. It takes n steps to reach to the top.
 * Each time you can either climb 1 or 2 steps. In how many distinct ways 
 * can you climb to the top?
 * Note: Given n will be a positive integer.
 * 
 * Example 1:
 * Input: 2
 * Output: 2
 * Explanation: There are two ways to climb to the top.
 * 1. 1 step + 1 step
 * 2. 2 steps
 * 
 * Example 2:
 * Input: 3
 * Output: 3
 * Explanation: There are three ways to climb to the top.
 * 1. 1 step + 1 step + 1 step
 * 2. 1 step + 2 steps
 * 3. 2 steps + 1 step
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_70
    {
        public class Solution
        {
            public int ClimbStairs(int n)
            {
                int[] memo = new int[n + 1];

                for (int i = 0; i <= n; i++)
                {
                    if (i < 3)
                    {
                        memo[i] = i;
                    }
                    else
                    {
                        memo[i] = memo[i - 1] + memo[i - 2];
                    }
                }
                return memo[memo.Length - 1];
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(n). Single loop up to n.
 * 		Space complexity : O(n). memo array of size n is used
 */
