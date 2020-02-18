/*
 * Problem 1002: Find Common Characters
 * Difficulty: Easy
 * 
 * Given an array A of strings made only from lowercase letters, return a list 
 * of all characters that show up in all strings within the list (including 
 * duplicates).  For example, if a character occurs 3 times in all strings 
 * but not 4 times, you need to include that character three times in the 
 * final answer.
 * 
 * You may return the answer in any order.
 * 
 * Example 1:
 * Input: ["bella","label","roller"]
 * Output: ["e","l","l"]
 * 
 * Example 2:
 * Input: ["cool","lock","cook"]
 * Output: ["c","o"]
 *  
 * Note:
 *     1 <= A.length <= 100
 *     1 <= A[i].length <= 100
 *     A[i][j] is a lowercase letter
 */

using System.Collections.Generic;
using System.Linq;

namespace CSharpProblems
{
    public class Problem_1002
    {
        public class Solution
        {
            public IList<string> CommonChars(string[] A)
            {
                Dictionary<char, int[]> dic = new Dictionary<char, int[]>();
                for (int i = 0; i < A.Length; ++i)
                {
                    foreach (char ch in A[i])
                    {
                        if (!dic.ContainsKey(ch))
                            dic.Add(ch, new int[A.Length]);

                        dic[ch][i]++;
                    }
                }

                List<string> res = new List<string>();
                foreach (var p in dic)
                {
                    char ch = p.Key;
                    int min = p.Value.Min();
                    if (min > 0)
                    {
                        for (int i = 0; i < min; ++i)
                            res.Add(ch.ToString());
                    }

                }
                return res;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity :
 */
