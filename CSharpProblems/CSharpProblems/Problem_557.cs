/*
 * Problem 557: Reverse Words in a String III
 * Difficulty: Easy
 * 
 * Given a string, you need to reverse the order of characters in each word 
 * within a sentence while still preserving whitespace and initial word order.
 * 
 * Example 1:
 *      Input: "Let's take LeetCode contest"
 *      Output: "s'teL ekat edoCteeL tsetnoc"
 * 
 * Note: In the string, each word is separated by single space and there will 
 * 		 not be any extra space in the string. 
 */
 
using System.Text;

namespace CSharpProblems
{
    public class Problem_557
    {
        public class Solution
        {
            public string ReverseWords(string s)
            {
                string[] words = s.Split(' ');
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < words.Length; i++)
                {
                    sb.Append(ReverseWord(words[i]));

                    if (i != words.Length - 1)
                    {
                        sb.Append(" ");
                    }

                }
                return sb.ToString();
            }

            private string ReverseWord(string word)
            {
                StringBuilder reverse = new StringBuilder();
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reverse.Append(word[i]);
                }
                return reverse.ToString();
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity : 
 */
