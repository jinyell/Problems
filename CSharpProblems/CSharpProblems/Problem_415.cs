/*
 * Problem 415: Add Strings
 * Difficulty: Easy
 *
 * Given two non-negative integers num1 and num2 represented as string, return the sum of num1 and num2.
 * 
 * Note:
 * 
 * The length of both num1 and num2 is < 5100.
 * Both num1 and num2 contains only digits 0-9.
 * Both num1 and num2 does not contain any leading zero.
 * You must not use any built-in BigInteger library or convert the inputs to integer directly.
 */

using System.Text;

namespace CSharpProblems
{
    public class Problem_415
    {
        public class Solution
        {
            public string AddStrings(string num1, string num2)
            {
                int index1 = num1.Length - 1;
                int index2 = num2.Length - 1;
                int carry = 0;
                StringBuilder sb = new StringBuilder();

                while (index1 >= 0 || index2 >= 0)
                {
                    int digit1 = index1 >= 0 ? num1[index1] - '0' : 0;
                    int digit2 = index2 >= 0 ? num2[index2] - '0' : 0;

                    int sum = digit1 + digit2 + carry;
                    carry = sum / 10;
                    int digit = sum % 10;

                    sb.Insert(0, digit);

                    index1--;
                    index2--;
                }

                if (carry > 0)
                {
                    sb.Insert(0, carry);
                }

                return sb.ToString();
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 		Time complexity : 
 * 		Space complexity:
 */
