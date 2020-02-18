/*
 * Problem 693: Binary Number with Alternating Bits
 * Difficulty: Easy
 * 
 * Given a positive integer, check whether it has alternating bits: namely, 
 * if two adjacent bits will always have different values.
 * 
 * Example 1:
 *      Input: 5
 *      Output: True
 *      Explanation: The binary representation of 5 is: 101
 * 
 * Example 2:
 *      Input: 7
 *      Output: False
 *      Explanation: The binary representation of 7 is: 111.
 * 
 * Example 3:
 *      Input: 11
 *      Output: False
 *      Explanation: The binary representation of 11 is: 1011.
 * 
 * Example 4:
 *      Input: 10
 *      Output: True
 *      Explanation: The binary representation of 10 is: 1010.
 */

namespace CSharpProblems
{
    public class Problem_693
    {
        public class Solution
        {
            public bool HasAlternatingBits(int n)
            {
                int current = n % 2;
                n /= 2;

                while (n > 0)
                {
                    if (current == n % 2) { return false; }
                    current = n % 2;
                    n /= 2;
                }

                return true;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(1). For arbitrary inputs, we do O(w) work, where 
 * 						   w is the number of bits in n. However, w <= 32
 * 		Space complexity : O(1)
 */
