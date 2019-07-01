/*
 * Problem 28: Implement strStr()
 * Difficulty: Easy
 * 
 * Implement strStr().
 * Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
 * 
 * Example 1:
 * Input: haystack = "hello", needle = "ll"
 * Output: 2
 * 
 * Example 2:
 * Input: haystack = "aaaaa", needle = "bba"
 * Output: -1
 * 
 * Clarification:
 * What should we return when needle is an empty string? This is a great question to ask during an interview.
 * For the purpose of this problem, we will return 0 when needle is an empty string. This is consistent to C's strstr() and Java's indexOf().
 */

namespace CSharpProblems
{
    public class Problem_28
    {
        public class Solution
        {
            public int StrStr(string haystack, string needle)
            {
                if (string.IsNullOrEmpty(needle))
                {
                    return 0;
                }

                if (string.IsNullOrEmpty(haystack))
                {
                    return -1;
                }

                return haystack.IndexOf(needle);
            }
        }
    }
}
