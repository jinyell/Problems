/*
 * Problem 953: Verifying an Alien Dictionary
 * Difficulty: Easy
 * 
 * In an alien language, surprisingly they also use english lowercase letters, 
 * but possibly in a different order. The order of the alphabet is some 
 * permutation of lowercase letters.
 * 
 * Given a sequence of words written in the alien language, and the order of 
 * the alphabet, return true if and only if the given words are sorted 
 * lexicographicaly in this alien language.
 * 
 * Example 1:
 * Input: words = ["hello","leetcode"], order = "hlabcdefgijkmnopqrstuvwxyz"
 * Output: true
 * Explanation: As 'h' comes before 'l' in this language, then the 
 * 				sequence is sorted.
 * 
 * Example 2:
 * Input: words = ["word","world","row"], order = "worldabcefghijkmnpqstuvxyz"
 * Output: false
 * Explanation: As 'd' comes after 'l' in this language, then 
 * 				words[0] > words[1], hence the sequence is unsorted.
 * 
 * Example 3:
 * Input: words = ["apple","app"], order = "abcdefghijklmnopqrstuvwxyz"
 * Output: false
 * Explanation: The first three characters "app" match, and the second 
 * 				string is shorter (in size.) According to lexicographical rules 
 * 				"apple" > "app", because 'l' > '∅', where '∅' is defined as the 
 * 				blank character which is less than any other character
 * 
 * Note:
 *     1 <= words.length <= 100
 *     1 <= words[i].length <= 20
 *     order.length == 26
 *     All characters in words[i] and order are english lowercase letters.
 */

using System;

namespace CSharpProblems
{
    public class Problem_953
    {
        public class Solution
        {
            public bool IsAlienSorted(string[] words, string order)
            {
                if (words == null || words.Length <= 1)
                    return true;

                for (int i = 1; i < words.Length; i++)
                {
                    var s1 = words[i - 1];
                    var s2 = words[i];

                    int total = Math.Min(s1.Length, s2.Length);

                    if (!Check(s1, s2, total, order))
                        return false;
                }

                return true;
            }

            private bool Check(string s1, string s2, int total, string order)
            {
                for (var i = 0; i < total; i++)
                {
                    if (s1[i] == s2[i])
                        continue;

                    return (order.IndexOf(s1[i]) < order.IndexOf(s2[i]));
                }
                return false;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity : 
 */
