﻿/*
 * Problem 367: Valid Perfect Square
 * Difficulty: Easy
 *
 * Given a positive integer num, write a function which returns True if num 
 * is a perfect square else False.
 * 
 * Note: Do not use any built-in library function such as sqrt.
 * 
 * Example 1:
 *      Input: 16
 *      Output: true
 * 
 * Example 2:
 *      Input: 14
 *      Output: false
 */

namespace CSharpProblems
{
    public class Problem_367
    {
        public class Solution
        {
            public bool IsPerfectSquare(int num)
            {
                int low = 1;
                int high = num;

                while (low <= high)
                {
                    long mid = (low + high) / 2;
                    if (mid * mid == num)
                    {
                        return true;
                    }
                    else if (mid * mid < num)
                    {
                        low = (int)mid + 1;
                    }
                    else
                    {
                        high = (int)mid - 1;
                    }
                }

                return false;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 		Time complexity : 
 * 		Space complexity:
 */