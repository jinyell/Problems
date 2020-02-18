/*
 * Problem 509: Fibonacci Number
 * Difficulty: Easy
 * 
 * The Fibonacci numbers, commonly denoted F(n) form a sequence, called the 
 * Fibonacci sequence, such that each number is the sum of the two preceding 
 * ones, starting from 0 and 1. That is,
 * 
 * F(0) = 0,   F(1) = 1
 * F(N) = F(N - 1) + F(N - 2), for N > 1.
 * 
 * Given N, calculate F(N).
 * 
 * Example 1:
 *      Input: 2
 *      Output: 1
 *      Explanation: F(2) = F(1) + F(0) = 1 + 0 = 1.
 * 
 * Example 2:
 *      Input: 3
 *      Output: 2
 *      Explanation: F(3) = F(2) + F(1) = 1 + 1 = 2.
 * 
 * Example 3:
 *      Input: 4
 *      Output: 3
 *      Explanation: F(4) = F(3) + F(2) = 2 + 1 = 3.
 * 
 * Note: 0 ≤ N ≤ 30.
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_509
    {
        public class Solution
        {
            public int Fib(int N)
            {
                Dictionary<int, int> dict = new Dictionary<int, int>();
                return FibonacciNumber(dict, N);
            }

            private int FibonacciNumber(Dictionary<int, int> dict, int n)
            {
                if (dict.ContainsKey(n))
                {
                    return dict[n];
                }

                int result;
                if (n < 2)
                {
                    result = n;
                }
                else
                {
                    result = FibonacciNumber(dict, n - 1) +
                             FibonacciNumber(dict, n - 2);
                }

                dict.Add(n, result);
                return result;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity : 
 */
