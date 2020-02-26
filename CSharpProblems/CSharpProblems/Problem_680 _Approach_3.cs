/*
 * Problem 680: Valid Palindrome II
 * Difficulty: Easy
 * 
 * Given a non-empty string s, you may delete at most one character. Judge whether you can make it a palindrome.
 * 
 * Example 1:
 *      Input: "aba"
 *      Output: True
 * Example 2:
 *      Input: "abca"
 *      Output: True
 *      Explanation: You could delete the character 'c'.
 * Note:
 *      The string will only contain lowercase characters a-z. The maximum length of the string is 50000.
 */

using System.Text;

namespace CSharpProblems
{
    public class Problem_680_Approach_3
    {
        public class Solution
        {
            public bool ValidPalindrome(string s)
            {
                StringBuilder sb = new StringBuilder(s);

                for (int i = 0; i < s.Length; i++)
                {
                    char curr = sb[i];
                    sb.Remove(i, 1);

                    if (IsPalindrome(sb.ToString()))
                    {
                        return true;
                    }

                    sb.Insert(i, curr);
                }

                return IsPalindrome(s);
            }

            private bool IsPalindrome(string s)
            {
                for (int i = 0; i < s.Length / 2; i++)
                {
                    if (s[i] != s[s.Length - i - 1])
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(N^2) where N is the length of the string. We do the following NN times: create a string of length N and iterate over it.
 * 		Space complexity : O(N), the space used by our candidate answer.
 */
