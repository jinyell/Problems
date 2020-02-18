/*
 * Problem 242: Valid Anagram
 * Difficulty: Easy
 * 
 * Given two strings s and t , write a function to determine if t is an 
 * anagram of s.
 * 
 * Example 1:
 *      Input: s = "anagram", t = "nagaram"
 *      Output: true
 * 
 * Example 2:
 *      Input: s = "rat", t = "car"
 *      Output: false
 * 
 * Note: You may assume the string contains only lowercase alphabets.
 * 
 * Follow up: What if the inputs contain unicode characters? How would you 
 * 			  adapt your solution to such case?
 */

namespace CSharpProblems
{
    public class Problem_242
    {
        public class Solution
        {
            public bool IsAnagram(string s, string t)
            {
                if (s.Length != t.Length)
                {
                    return false;
                }

                int[] chars = new int[256];

                for (int i = 0; i < s.Length; i++)
                {
                    chars[s[i]]++;
                }

                for (int i = 0; i < t.Length; i++)
                {
                    chars[t[i]]--;
                }

                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] != 0)
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
 * Complexity Analysis:
 * 
 * 		Time complexity : O(n). Time complexity is O(n) because accessing the 
 * 						  counter table is a constant time operation.
 * 		Space complexity: O(1). Although we do not use extra space, the space 
 * 						  complexity is O(1) because the table's size stays 
 * 						  constant no matter hwo large n is.
 */
