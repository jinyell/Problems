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

using System;
using System.Linq;

namespace CSharpProblems
{
    public class Problem_1119
    {
        public class Solution
        {
            public string RemoveVowels(string S)
            {
                return String.Join("", S.Where(c => "aeiou".IndexOf(c) == -1));
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity :
 */
