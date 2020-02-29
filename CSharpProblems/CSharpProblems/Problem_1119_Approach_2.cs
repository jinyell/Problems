/*
 * Problem 1119: Remove Vowels from a String
 * Difficulty: Easy
 * 
 * Given a string S, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.
 * 
 * Example 1:
 * Input: "leetcodeisacommunityforcoders"
 * Output: "ltcdscmmntyfrcdrs"
 * 
 * Example 2:
 * Input: "aeiou"
 * Output: ""
 *  
 * Note:
 *      S consists of lowercase English letters only.
 *      1 <= S.length <= 1000
 */

using System.Collections.Generic;
using System.Text;

namespace CSharpProblems
{
    public class Problem_1119_Approach_2
    {
        public class Solution
        {
            public string RemoveVowels(string S)
            {
                HashSet<char> vowels = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < S.Length; i++)
                {
                    if (vowels.Contains(S[i]) == false)
                    {
                        sb.Append(S[i]);
                    }
                }

                return sb.ToString();
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity :
 */
