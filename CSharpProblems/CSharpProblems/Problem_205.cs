/*
 * Problem 205: Isomorphic Strings
 * Difficulty: Easy
 * 
 * Given two strings s and t, determine if they are isomorphic.
 * 
 * Two strings are isomorphic if the characters in s can be replaced to get t.
 * 
 * All occurrences of a character must be replaced with another character 
 * while preserving the order of characters. No two characters may map to the 
 * same character but a character may map to itself.
 * 
 * Example 1:
 *      Input: s = "egg", t = "add"
 * Output: true
 * 
 * Example 2:
 *      Input: s = "foo", t = "bar"
 *      Output: false
 * 
 * Example 3:
 *      Input: s = "paper", t = "title"
 * Output: true
 * 
 * Note: You may assume both s and t have the same length.
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_205
    {
        public class Solution
        {
            public bool IsIsomorphic(string s, string t)
            {
                if (string.IsNullOrEmpty(s) && string.IsNullOrEmpty(t))
                {
                    return true;
                }

                if (s.Length != t.Length)
                {
                    return false;
                }

                Dictionary<char, char> dict = new Dictionary<char, char>();
                for (int i = 0; i < s.Length; i++)
                {
                    if (dict.ContainsKey(s[i]))
                    {
                        if (dict[s[i]] != t[i])
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (dict.ContainsValue(t[i]))
                        {
                            return false;
                        }
                        else
                        {
                            dict[s[i]] = t[i];
                        }
                    }
                }
                return true;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity : 
 */
