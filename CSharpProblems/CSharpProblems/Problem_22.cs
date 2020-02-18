/*
 * Problem 22: Generate Parentheses
 * Difficulty: Medium
 * 
 * Given n pairs of parentheses, write a function to generate all 
 * combinations of well-formed parentheses.
 * 
 * For example, given n = 3, a solution set is:
 * 
 * [
 *   "((()))",
 *   "(()())",
 *   "(())()",
 *   "()(())",
 *   "()()()"
 * ]
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_22
    {
        public class Solution
        {
            public IList<string> GenerateParenthesis(int n)
            {
                List<string> ans = new List<string>();
                BackTrack(ans, string.Empty, 0, 0, n);
                return ans;
            }

            public void BackTrack(List<string> ans, string curr, int open,
                                  int close, int max)
            {
                if (curr.Length == (max * 2))
                {
                    ans.Add(curr);
                    return;
                }

                if (open < max)
                {
                    BackTrack(ans, curr + "(", open + 1, close, max);
                }

                if (close < open)
                {
                    BackTrack(ans, curr + ")", open, close + 1, max);
                }
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 
 * 		Time complexity : O((4^n) / (n * sqrt(n))) Each valid sequence has 
 * 						  at most n steps during the backtracking procedure.
 * 		Space complexity: O((4^n) / (n * sqrt(n))) Each valid sequence has 
 * 						  at most n steps during the backtracking procedure.
 */
