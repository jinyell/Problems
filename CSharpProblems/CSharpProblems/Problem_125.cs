/*
 * Problem 125: Valid Palindrome
 * Difficulty: Easy
 * 
 * Given a string, determine if it is a palindrome, considering only 
 * alphanumeric characters and ignoring cases.
 * 
 * Note: For the purpose of this problem, we define empty string as 
 * valid palindrome.
 * 
 * Example 1:
 *      Input: "A man, a plan, a canal: Panama"
 *      Output: true
 * 
 * Example 2:
 *      Input: "race a car"
 *      Output: false
 */

namespace CSharpProblems
{
    public class Problem_125
    {
        public class Solution
        {
            public bool IsPalindrome(string s)
            {
                int startIndex = 0;
                int endIndex = s.Length - 1;
                char startChar;
                char endChar;

                while (startIndex < endIndex)
                {
                    startChar = s[startIndex];
                    endChar = s[endIndex];

                    if (char.IsLetterOrDigit(startChar) &&
                        char.IsLetterOrDigit(endChar))
                    {
                        if (char.ToUpper(startChar) != char.ToUpper(endChar))
                        {
                            return false;
                        }
                        startIndex++;
                        endIndex--;
                    }
                    else
                    {
                        if (char.IsLetterOrDigit(startChar) == false)
                        {
                            startIndex++;
                        }
                        else
                        {
                            endIndex--;
                        }
                    }
                }
                return true;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 
 * Time complexity :
 * Space complexity: 
 */
