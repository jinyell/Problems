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

namespace CSharpProblems
{
    public class Problem_680_Approach_2
    {
        public class Solution
        {
            public bool ValidPalindrome(string s)
            {
                for (int i = 0; i < s.Length / 2; i++)
                {
                    if (s[i] != s[s.Length - 1 - i])
                    {
                        int end = s.Length - 1 - i;
                        return IsPalindrome(s, i + 1, end) || IsPalindrome(s, i, end - 1);
                    }
                }

                return true;
            }

            private bool IsPalindrome(string s, int start, int end)
            {
                for (int k = start; k <= start + (end - start) / 2; k++)
                {
                    if (s[k] != s[end - k + start])
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
 * Greedy Approach
 * 
 * Complexity Analysis
 * 		Time complexity  : O(N) where N is the length of the string. Each of two checks of whether some substring is a palindrome is O(N).
 * 		Space complexity : O(1) additional complexity. Only pointers were stored in memory.
 */
