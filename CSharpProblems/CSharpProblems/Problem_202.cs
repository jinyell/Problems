﻿/*
 * Problem 202: Happy Number
 * Difficulty: Easy
 * 
 * Write an algorithm to determine if a number is "happy".
 * 
 * A happy number is a number defined by the following process: Starting 
 * with any positive integer, replace the number by the sum of the squares 
 * of its digits, and repeat the process until the number equals 1 (where 
 * it will stay), or it loops endlessly in a cycle which does not include 1. 
 * Those numbers for which this process ends in 1 are happy numbers.
 * 
 * Example: 
 *      Input: 19
 *      Output: true
 *      Explanation: 
 *          12 + 92 = 82
 *          82 + 22 = 68
 *          62 + 82 = 100
 *          12 + 02 + 02 = 1
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_202
    {
        public class Solution
        {
            public bool IsHappy(int n)
            {
                HashSet<int> hs = new HashSet<int>();

                while (!hs.Contains(n))
                {
                    if (n == 1)
                    {
                        return true;
                    }

                    hs.Add(n);

                    int sum = 0;
                    int remainder;
                    while (n != 0)
                    {
                        remainder = n % 10;
                        sum += (remainder * remainder);
                        n /= 10;
                    }
                    n = sum;
                }
                return false;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity : 
 */
