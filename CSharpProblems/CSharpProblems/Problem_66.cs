/*
 * Problem 66: Plus One
 * Difficulty: Easy
 * 
 * Given a non-empty array of digits representing a non-negative integer, 
 * plus one to the integer. The digits are stored such that the most 
 * significant digit is at the head of the list, and each element in the 
 * array contain a single digit. You may assume the integer does not contain 
 * any leading zero, except the number 0 itself.
 * 
 * Example 1:
 * Input: [1,2,3]
 * Output: [1,2,4]
 * Explanation: The array represents the integer 123.
 * 
 * Example 2:
 * Input: [4,3,2,1]
 * Output: [4,3,2,2]
 * Explanation: The array represents the integer 4321.
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_66
    {
        public class Solution
        {
            public int[] PlusOne(int[] digits)
            {
                List<int> answer = new List<int>();
                int carry = 1;

                for (int i = digits.Length - 1; i >= 0; i--)
                {
                    int result = digits[i] + carry;
                    if (result == 10)
                    {
                        carry = 1;
                        answer.Insert(0, (result - 10));
                    }
                    else
                    {
                        answer.Insert(0, result);
                        carry = 0;
                    }
                }

                if (carry == 1)
                {
                    answer.Insert(0, 1);
                }

                return answer.ToArray();
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity :
 */
