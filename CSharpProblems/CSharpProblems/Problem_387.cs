/*
 * Problem 387: First Unique Character in a String
 * Difficulty: Easy
 *
 * Given a string, find the first non-repeating character in it and return 
 * it's index. If it doesn't exist, return -1.
 * 
 * Examples:
 *      s = "leetcode"
 *      return 0.
 * 
 *      s = "loveleetcode",
 *      return 2.
 * 
 * Note: You may assume the string contain only lowercase letters. 
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_387
    {
        public class Solution
        {
            public int FirstUniqChar(string s)
            {
                Dictionary<char, int> dict = new Dictionary<char, int>();
                for (int i = 0; i < s.Length; i++)
                {
                    if (dict.ContainsKey(s[i]))
                    {
                        dict[s[i]]++;
                    }
                    else
                    {
                        dict[s[i]] = 1;
                    }
                }

                for (int i = 0; i < s.Length; i++)
                {
                    if (dict[s[i]] == 1)
                    {
                        return i;
                    }
                }
                return -1;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 		Time complexity : O(N) since we go through the string of length 
 * 						  N two times. 
 * 		Space complexity: O(N) since we have to keep a hash map with N elements
 */
