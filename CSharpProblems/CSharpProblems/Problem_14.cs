/*
 * Problem 14: Longest Common Prefix
 * Difficulty: Easy
 * 
 * Write a function to find the longest common prefix string amongst an array 
 * of strings. If there is no common prefix, return an empty string "".
 * 
 * Example 1:
 * Input: ["flower","flow","flight"]
 * Output: "fl"
 * 
 * Example 2:
 * Input: ["dog","racecar","car"]
 * Output: ""
 * Explanation: There is no common prefix among the input strings.
 * 
 * Note:
 * All given inputs are in lowercase letters a-z.
 */

namespace CSharpProblems
{
    public class Problem_14
    {
        public class Solution
        {
            public string LongestCommonPrefix(string[] strs)
            {
                if (strs.Length == 0)
                {
                    return string.Empty;
                }

                for (int i = 0; i < strs[0].Length; i++)
                {
                    for (int j = 0; j < strs.Length; j++)
                    {
                        if (strs[j].Length < (i + 1) ||
                            strs[j][i] != strs[0][i])
                        {
                            return strs[0].Substring(0, i);
                        }
                    }
                }
                return strs[0];
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(S), where S is the sum of all characters in all
						   strings. In the worst case there will be n equal
						   strings with length m and the algorithm performs
						   S = m * n character comparisons. In the best case
						   there are at most n * minLen comparisons where
						   minLen is the length of the shortest string the
						   array.
 * 		Space complexity : O(1). We only used constant extra space.
 */
