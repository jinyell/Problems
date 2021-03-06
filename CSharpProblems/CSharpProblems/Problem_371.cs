﻿/*
 * Problem 371: Sum of Two Integers
 * Difficulty: Easy
 *
 * Calculate the sum of two integers a and b, but you are not allowed to use 
 * the operator + and -.
 * 
 * Example 1:
 *      Input: a = 1, b = 2
 *      Output: 3
 * 
 * Example 2:
 *      Input: a = -2, b = 3
 *      Output: 1
 */

namespace CSharpProblems
{
    public class Problem_371
    {
        public class Solution
        {
            public int GetSum(int a, int b)
            {
                while (b != 0)
                {
                    int carry = a & b;
                    a = a ^ b;
                    b = carry << 1;
                }
                return a;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 		Time complexity : 
 * 		Space complexity:
 */
