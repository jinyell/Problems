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

using System.Text;

namespace CSharpProblems
{
    public class Problem_1119_Approach_3
    {
        public class Solution
        {
            public string RemoveVowels(string S)
            {
                StringBuilder sb = new StringBuilder();
                foreach (char c in S)
                {
                    if (c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u')
                    {
                        sb.Append(c);
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
