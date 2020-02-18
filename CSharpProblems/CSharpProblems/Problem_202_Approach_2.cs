/*
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

namespace CSharpProblems
{
    public class Problem_202_Approach_2
    {
        public class Solution
        {
            public bool IsHappy(int n)
            {
                int slow = n;
                int fast = n;

                do
                {
                    slow = GetSum(slow);
                    fast = GetSum(GetSum(fast));
                } while (slow != fast);

                return fast == 1;
            }

            private int GetSum(int n)
            {
                int sum = 0;
                int remainder = 0;

                while (n != 0)
                {
                    remainder = n % 10;
                    sum += (remainder * remainder);
                    n /= 10;
                }
                return sum;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity : 
 */
