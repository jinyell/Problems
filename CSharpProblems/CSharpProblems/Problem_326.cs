/*
 * Problem 326: Power of Three
 * Difficulty: Easy
 *
 * Given an integer, write a function to determine if it is a power of three.
 * 
 * Example 1:
 *      Input: 27
 *      Output: true
 * 
 * Example 2:
 *      Input: 0
 *      Output: false
 * 
 * Example 3:
 *      Input: 9
 *      Output: true
 * 
 * Example 4:
 *      Input: 45
 *      Output: false
 * 
 * Follow up: Could you do it without using any loop / recursion?
 */

namespace CSharpProblems
{
    public class Problem_326
    {
        public class Solution
        {
            public bool IsPowerOfThree(int n)
            {
                if (n == 0)
                {
                    return false;
                }

                while ((n % 3) == 0)
                {
                    n /= 3;
                }
                return (n == 1);
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 		Time complexity : O(logb(n)). In our case that is O(log3(n). 
 * 						  The number of divisions is given by that logarithm.
 * 		Space complexity: O(1). We are not using any additional memory.
 */
