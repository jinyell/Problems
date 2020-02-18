/*
 * Problem 709: To Lower Case
 * Difficulty: Easy
 * 
 * Implement function ToLowerCase() that has a string parameter str, and 
 * returns the same string in lowercase.
 * 
 * Example 1:
 *      Input: "Hello"
 *      Output: "hello"
 * 
 * Example 2:
 *      Input: "here"
 *      Output: "here"
 * 
 * Example 3:
 *      Input: "LOVELY"
 *      Output: "lovely"
 */

namespace CSharpProblems
{
    public class Problem_709
    {
        public class Solution
        {
            public string ToLowerCase(string str)
            {
                string result = string.Empty;

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] >= 'A' && str[i] <= 'Z')
                    {
                        result += (char)(str[i] - 'A' + 'a');
                    }
                    else
                    {
                        result += str[i];
                    }
                }
                return result;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity : 
 */
