﻿/*
 * Problem 50: Pow(x, n)
 * Difficulty: Medium
 * 
 * Implement pow(x, n), which calculates x raised to the power n (xn).
 * 
 * Example 1:
 *      Input: 2.00000, 10
 *      Output: 1024.00000
 * 
 * Example 2:
 *      Input: 2.10000, 3
 *      Output: 9.26100
 * 
 * Example 3:
 *      Input: 2.00000, -2
 *      Output: 0.25000
 *      Explanation: 2-2 = 1/22 = 1/4 = 0.25
 * 
 * Note:
 *      -100.0 < x < 100.0
 *      n is a 32-bit signed integer, within the range [−231, 231 − 1]
 */

namespace CSharpProblems
{
    public class Problem_50
    {
        public class Solution
        {
            public double MyPow(double x, int n)
            {
                if (n < 0)
                {
                    return 1 / x * MyPow(1 / x, -(n + 1));
                }

                if (n == 0)
                {
                    return 1;
                }

                if (n == 2)
                {
                    return x * x;
                }

                if (n % 2 == 0)
                {
                    return MyPow(MyPow(x, n / 2), 2);
                }
                else
                {
                    return x * MyPow(MyPow(x, n / 2), 2);
                }
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 
 * Time complexity :
 * Space complexity:
 */