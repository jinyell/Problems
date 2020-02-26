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
    public class Problem_680
    {
        public class Solution
        {
            public bool ValidPalindrome(string s)
            {
                int start = 0;
                int end = s.Length - 1;

                while (s[start] == s[end] && start < end)
                {
                    start++;
                    end--;
                }

                if (end - start == 1 || end == start)
                {
                    return true;
                }

                return IsValid(s, start + 1, end) || IsValid(s, start, end - 1);
            }

            private bool IsValid(string s, int start, int end)
            {
                while (start < end)
                {
                    if (s[start] == s[end])
                    {
                        start++;
                        end--;
                    }
                    else
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
 * 		Time complexity  : O(n)
 * 		Space complexity : O(1)
 */
