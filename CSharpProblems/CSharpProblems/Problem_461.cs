/*
 * Problem 461: Assign Cookies
 * Difficulty: Easy
 * 
 * The Hamming distance between two integers is the number of positions at 
 * which the corresponding bits are different.
 * 
 * Given two integers x and y, calculate the Hamming distance.
 * 
 * Note: 0 ≤ x, y < 231.
 * 
 * Example:
 *      Input: x = 1, y = 4
 *      Output: 2
 * 
 *      Explanation:
 *          1   (0 0 0 1)
 *          4   (0 1 0 0)
 *                 ↑   ↑
 * 
 *      The above arrows point to positions where the corresponding bits 
 * 		are different.
 */

namespace CSharpProblems
{
    public class Problem_461
    {
        public class Solution
        {
            public int HammingDistance(int x, int y)
            {
                int dist = x ^ y;
                int count = 0;
                while (dist != 0)
                {
                    if ((dist & 1) == 1) { count++; }
                    dist = dist >> 1;
                }
                return count;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity : 
 */
