/*
 * Problem 1281: Subtract the Product and Sum of Digits of an Integer
 * Difficulty: Easy
 * 
 * Given an integer number n, return the difference between the product of its digits and the sum of its digits.
 *  
 * Example 1:
 *      Input: n = 234
 *      Output: 15 
 *      Explanation: 
 *          Product of digits = 2 * 3 * 4 = 24 
 *          Sum of digits = 2 + 3 + 4 = 9 
 *          Result = 24 - 9 = 15
 * 
 * Example 2:
 *      Input: n = 4421
 *      Output: 21
 *      Explanation: 
 *          Product of digits = 4 * 4 * 2 * 1 = 32 
 *          Sum of digits = 4 + 4 + 2 + 1 = 11 
 *          Result = 32 - 11 = 21
 *  
 * Constraints: 1 <= n <= 10^5
 */

namespace CSharpProblems
{
    public class Problem_1281
    {
        public class Solution
        {
            public int SubtractProductAndSum(int n)
            {
                int multiple = 1;
                int sum = 0;

                while (n > 0)
                {
                    int digit = n % 10;
                    multiple *= digit;
                    sum += digit;
                    n /= 10;
                }

                return multiple - sum;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity :
 */
