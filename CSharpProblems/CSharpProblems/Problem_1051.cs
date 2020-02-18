/*
 * Problem 1051: Height Checker
 * Difficulty: Easy
 * 
 * Students are asked to stand in non-decreasing order of heights for an 
 * annual photo.
 * 
 * Return the minimum number of students not standing in the right positions.  
 * (This is the number of students that must move in order for all students to 
 * be standing in non-decreasing order of height.)
 * 
 * Example 1:
 * Input: [1,1,4,2,1,3]
 * Output: 3
 * Explanation: 
 * Students with heights 4, 3 and the last 1 are not standing in the right 
 * positions.
 * 
 * Note:
 *     1 <= heights.length <= 100
 *     1 <= heights[i] <= 100
 */

namespace CSharpProblems
{
    public class Problem_1051
    {
        public class Solution
        {
            public int HeightChecker(int[] heights)
            {
                int[] freq = new int[101];
                for (int i = 0; i < heights.Length; i++)
                {
                    freq[heights[i]]++;
                }

                int total = 0;
                int currentHeight = 0;

                for (int i = 0; i < heights.Length; i++)
                {
                    while (freq[currentHeight] == 0)
                    {
                        currentHeight++;
                    }

                    if (currentHeight != heights[i])
                    {
                        total++;
                    }
                    freq[currentHeight]--;
                }

                return total;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity :
 */
