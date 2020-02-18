/*
 * Problem 383: Ransom Note
 * Difficulty: Easy
 *
 * Given an arbitrary ransom note string and another string containing 
 * letters from all the magazines, write a function that will return true 
 * if the ransom note can be constructed from the magazines ; otherwise, 
 * it will return false.
 * 
 * Each letter in the magazine string can only be used once in your ransom note.
 * 
 * Note: You may assume that both strings contain only lowercase letters.
 * 
 *      canConstruct("a", "b") -> false
 *      canConstruct("aa", "ab") -> false
 *      canConstruct("aa", "aab") -> true
 */

namespace CSharpProblems
{
    public class Problem_383
    {
        public class Solution
        {
            public bool CanConstruct(string ransomNote, string magazine)
            {
                int[] freq = new int[256];
                for (int i = 0; i < magazine.Length; i++)
                {
                    freq[magazine[i]]++;
                }

                for (int i = 0; i < ransomNote.Length; i++)
                {
                    freq[ransomNote[i]]--;
                    if (freq[ransomNote[i]] < 0)
                    {
                        return false;
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
