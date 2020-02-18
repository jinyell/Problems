/*
 * Problem 67: Add Binary
 * Difficulty: Easy
 * 
 * Given two binary strings, return their sum (also a binary string).
 * The input strings are both non-empty and contains only characters 1 or 0.
 * 
 * Example 1:
 * Input: a = "11", b = "1"
 * Output: "100"
 * 
 * Example 2:
 * Input: a = "1010", b = "1011"
 * Output: "10101"
 */

using System.Text;

namespace CSharpProblems
{
    public class Problem_67
    {
        public class Solution
        {
            public string AddBinary(string a, string b)
            {
                StringBuilder result = new StringBuilder();
                int carry = 0;

                for (int i = a.Length - 1, j = b.Length - 1; i >= 0 || j >= 0; i--, j--)
                {
                    int numA = (i >= 0) ? a[i] - '0' : 0;
                    int numB = (j >= 0) ? b[j] - '0' : 0;
                    int total = numA + numB + carry;
                    char binaryNum = (total == 2 || total == 0) ? '0' : '1';
                    result.Insert(0, binaryNum);
                    carry = (total > 1) ? 1 : 0;
                }

                return (carry == 1) ? result.Insert(0, 1).ToString()
                                    : result.ToString();
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity :
 */
