/*
 * Problem 1134: Armstrong Number
 * Difficulty: Easy
 * 
 * The k-digit number N is an Armstrong number if and only if the k-th power of each digit sums to N.
 * 
 * Given a positive integer N, return true if and only if it is an Armstrong number.
 * 
 * Example 1:
 *      Input: 153
 *      Output: true
 *      Explanation: 
 *          153 is a 3-digit number, and 153 = 1^3 + 5^3 + 3^3.
 * 
 * Example 2:
 *      Input: 123
 *      Output: false
 *      Explanation: 
 *          123 is a 3-digit number, and 123 != 1^3 + 2^3 + 3^3 = 36.
 *  
 * Note:
 *      1 <= N <= 10^8
 */

using System;

namespace CSharpProblems
{
    public class Problem_1134_Approach_2
    {
        public class Solution
        {
            public bool IsArmstrong(int N)
            {
                int num = N;
                int totalLength = (int)(Math.Log10(num) + 1);
                double sum = 0;

                while (num > 0)
                {
                    int digit = num % 10;
                    sum += Math.Pow(digit, totalLength);
                    num /= 10;
                }

                return sum == N;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity :
 */
