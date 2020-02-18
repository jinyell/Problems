/*
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
    public class Problem_367_Approach_2
    {
        public class Solution
        {
            public bool IsPerfectSquare(int num)
            {
                int i = 1;
                while (num > 0)
                {
                    num -= i;
                    i += 2;
                }

                return num == 0;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 		Time complexity : 
 * 		Space complexity:
 */
