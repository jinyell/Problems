/*
 * Problem 290: Word Pattern
 * Difficulty: Easy
 *
 * Given a pattern and a string str, find if str follows the same pattern.
 * 
 * Here follow means a full match, such that there is a bijection between a 
 * letter in pattern and a non-empty word in str.
 * 
 * Example 1:
 *      Input: pattern = "abba", str = "dog cat cat dog"
 *      Output: true
 * 
 * Example 2:
 *      Input:pattern = "abba", str = "dog cat cat fish"
 *      Output: false
 * 
 * Example 3:
 *      Input: pattern = "aaaa", str = "dog cat cat dog"
 *      Output: false
 * 
 * Example 4:
 *      Input: pattern = "abba", str = "dog dog dog dog"
 *      Output: false
 * 
 * Notes: You may assume pattern contains only lowercase letters, and str 
 * 		  contains lowercase letters that may be separated by a single space.
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_290
    {
        public class Solution
        {
            public bool WordPattern(string pattern, string str)
            {
                Dictionary<char, string> dict = new Dictionary<char, string>();
                string[] strs = str.Split(' ');

                if (string.IsNullOrEmpty(pattern) || string.IsNullOrEmpty(str)
                    || pattern.Length != strs.Length)
                {
                    return false;
                }

                for (int i = 0; i < strs.Length; i++)
                {
                    if (dict.ContainsKey(pattern[i]))
                    {
                        if (dict[pattern[i]] != strs[i])
                        {
                            return false;
                        }
                    }
                    else if (dict.ContainsValue(strs[i]))
                    {
                        return false;
                    }
                    else
                    {
                        dict.Add(pattern[i], strs[i]);
                    }
                }

                return true;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 		Time complexity :
 * 		Space complexity:
 */
