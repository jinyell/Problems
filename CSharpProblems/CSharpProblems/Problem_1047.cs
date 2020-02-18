/*
 * Problem 1047: Remove All Adjacent Duplicates In String
 * Difficulty: Easy
 * 
 * Given a string S of lowercase letters, a duplicate removal consists of 
 * choosing two adjacent and equal letters, and removing them.
 * 
 * We repeatedly make duplicate removals on S until we no longer can.
 * 
 * Return the final string after all such duplicate removals have been made.  
 * It is guaranteed the answer is unique.
 * 
 * Example 1:
 * Input: "abbaca"
 * Output: "ca"
 * Explanation: 
 * For example, in "abbaca" we could remove "bb" since the letters are 
 * adjacent and equal, and this is the only possible move.  The result of 
 * this move is that the string is "aaca", of which only "aa" is possible, 
 * so the final string is "ca".
 * 
 * Note:
 *     1 <= S.length <= 20000
 *     S consists only of English lowercase letters.
 */

using System.Collections.Generic;
using System.Text;

namespace CSharpProblems
{
    public class Problem_1047
    {
        public class Solution
        {
            public string RemoveDuplicates(string S)
            {
                HashSet<string> duplicates = new HashSet<string>();
                StringBuilder sb = new StringBuilder();

                for (char i = 'a'; i <= 'z'; i++)
                {
                    sb.Clear();
                    sb.Append(i);
                    sb.Append(i);
                    duplicates.Add(sb.ToString());
                }

                int prevLength = -1;
                while (prevLength != S.Length)
                {
                    prevLength = S.Length;
                    foreach (string duplicate in duplicates)
                    {
                        S = S.Replace(duplicate, "");
                    }
                }

                return S;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity :
 */
