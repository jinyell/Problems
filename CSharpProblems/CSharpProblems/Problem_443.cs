/*
 * Problem 443: String Compression
 * Difficulty: Easy
 * 
 * Given an array of characters, compress it in-place.
 * 
 * The length after compression must always be smaller than or equal to the original array.
 * 
 * Every element of the array should be a character (not int) of length 1.
 * 
 * After you are done modifying the input array in-place, return the new length of the array.
 * 
 *  
 * Follow up:
 * Could you solve it using only O(1) extra space?
 * 
 *  
 * Example 1:
 * 
 * Input:
 * ["a","a","b","b","c","c","c"]
 * 
 * Output:
 * Return 6, and the first 6 characters of the input array should be: ["a","2","b","2","c","3"]
 * 
 * Explanation:
 * "aa" is replaced by "a2". "bb" is replaced by "b2". "ccc" is replaced by "c3".
 *  
 * 
 * Example 2:
 * 
 * Input:
 * ["a"]
 * 
 * Output:
 * Return 1, and the first 1 characters of the input array should be: ["a"]
 * 
 * Explanation:
 * Nothing is replaced.
 */

namespace CSharpProblems
{
    public class Problem_443
    {
        public class Solution
        {
            public int Compress(char[] chars)
            {
                if (chars == null || chars.Length <= 0)
                {
                    return 0;
                }

                int anchor = 0, write = 0;
                for (int read = 0; read < chars.Length; read++)
                {
                    if (read + 1 == chars.Length || chars[read + 1] != chars[read])
                    {
                        chars[write++] = chars[anchor];
                        if (read > anchor)
                        {
                            foreach (var item in (read - anchor + 1).ToString().ToCharArray())
                            {
                                chars[write++] = item;
                            }
                        }

                        anchor = read + 1;
                    }
                }

                return write;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity : 
 */
