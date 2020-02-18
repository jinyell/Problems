﻿/*
 * Problem 804: Minimum Distance Between BST Nodes
 * Difficulty: Easy
 * 
 * International Morse Code defines a standard encoding where each letter 
 * is mapped to a series of dots and dashes, as follows: "a" maps to ".-", 
 * "b" maps to "-...", "c" maps to "-.-.", and so on.
 * 
 * For convenience, the full table for the 26 letters of the English alphabet 
 * is given below:
 * 
 * [".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",
 * ".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--",
 * "-..-","-.--","--.."]
 * 
 * Now, given a list of words, each word can be written as a concatenation 
 * of the Morse code of each letter. For example, "cba" can be written as 
 * "-.-..--...", (which is the concatenation "-.-." + "-..." + ".-"). We'll 
 * call such a concatenation, the transformation of a word.
 * 
 * Return the number of different transformations among all words we have.
 * 
 * Example:
 * Input: words = ["gin", "zen", "gig", "msg"]
 * Output: 2
 * Explanation: 
 * The transformation of each word is:
 * "gin" -> "--...-."
 * "zen" -> "--...-."
 * "gig" -> "--...--."
 * "msg" -> "--...--."
 * 
 * There are 2 different transformations, "--...-." and "--...--.".
 * 
 * Note:
 *     The length of words will be at most 100.
 *     Each words[i] will have length in range [1, 12].
 *     words[i] will only consist of lowercase letters.
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_804
    {
        public class Solution
        {
            public int UniqueMorseRepresentations(string[] words)
            {
                string[] morse = new string[26] { ".-", "-...", "-.-.", "-..",
                ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--",
                "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-",
                ".--", "-..-", "-.--", "--.." };
                HashSet<string> uniqueMorse = new HashSet<string>();

                for (int i = 0; i < words.Length; i++)
                {
                    string code = string.Empty;
                    for (int j = 0; j < words[i].Length; j++)
                    {
                        code += morse[words[i][j] - 'a'];
                    }
                    uniqueMorse.Add(code);
                }
                return uniqueMorse.Count;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(S), where S is the sum of the lengths of words 
 * 			in words. We iterate through each character of each word in words.
 * 		Space complexity : O(S)
 */
