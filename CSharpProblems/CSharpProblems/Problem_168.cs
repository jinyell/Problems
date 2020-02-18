/*
 * Problem 168: Excel Sheet Column Title
 * Difficulty: Easy
 * 
 * Given a positive integer, return its corresponding column title as 
 * appear in an Excel sheet.
 * 
 * For example:
 *     1 -> A
 *     2 -> B
 *     3 -> C
 *     ...
 *     26 -> Z
 *     27 -> AA
 *     28 -> AB 
 *     ...
 * 
 * Example 1:
 *      Input: 1
 *      Output: "A"
 * 
 * Example 2:
 *      Input: 28
 *      Output: "AB"
 * 
 * Example 3:
 *      Input: 701
 *      Output: "ZY"
 */

using System.Text;

namespace CSharpProblems
{
    public class Problem_168
    {
        public class Solution
        {
            public string ConvertToTitle(int n)
            {
                StringBuilder result = new StringBuilder();

                while (n > 0)
                {
                    n--;
                    result.Insert(0, (char)('A' + n % 26));
                    n /= 26;
                }

                return result.ToString();
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity : 
 */
