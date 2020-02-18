/*
 * Problem 409: Longest Palindrome
 * Difficulty: Easy
 *
 * Given a string which consists of lowercase or uppercase letters, find the 
 * length of the longest palindromes that can be built with those letters.
 * 
 * This is case sensitive, for example "Aa" is not considered a 
 * palindrome here.
 * 
 * Note: Assume the length of given string will not exceed 1,010.
 * 
 * Example:
 *      Input:
 *          "abccccdd"
 * 
 *      Output:
 *          7
 * 
 * Explanation: One longest palindrome that can be built is "dccaccd", 
 * 				whose length is 7.
 */

namespace CSharpProblems
{
    public class Problem_409
    {
        public class Solution
        {
            public int LongestPalindrome(string s)
            {
                int[] count = new int[128];

                for (int i = 0; i < s.Length; i++)
                {
                    count[s[i]]++;
                }

                int longest = 0;
                for (int i = 0; i < count.Length; i++)
                {
                    longest += (count[i] / 2) * 2;

                    if (longest % 2 == 0 && count[i] % 2 == 1)
                    {
                        longest++;
                    }
                }

                return longest;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 		Time complexity : O(N) where N is the length of s. We need to count 
 * 						  each letter.
 * 		Space complexity: O(1), the space for our count, as the alphabet 
 * 						  size of s is fixed. We should also consider that in 
 * 						  a bit complexity model, technically we need O(logN) 
 * 						  bits to store the count values.
 */
