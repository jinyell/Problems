/*
 * Problem 167: Two Sum II - Input array is sorted
 * Difficulty: Easy
 * 
 * Given an array of integers that is already sorted in ascending order, 
 * find two numbers such that they add up to a specific target number.
 * 
 * The function twoSum should return indices of the two numbers such that 
 * they add up to the target, where index1 must be less than index2.
 * 
 * Note:
 *     - Your returned answers (both index1 and index2) are not zero-based.
 *     - You may assume that each input would have exactly one solution and 
 * 		 you may not use the same element twice.
 * 
 * Example:
 *      Input: numbers = [2,7,11,15], target = 9
 *      Output: [1,2]
 *      Explanation: The sum of 2 and 7 is 9. Therefore index1 = 1, index2 = 2.
 */

namespace CSharpProblems
{
    public class Problem_167
    {
        public class Solution
        {
            public int[] TwoSum(int[] numbers, int target)
            {
                int startIndex = 0;
                int endIndex = numbers.Length - 1;
                while (startIndex < endIndex)
                {
                    if (numbers[startIndex] + numbers[endIndex] == target)
                    {
                        return new int[] { startIndex + 1, endIndex + 1 };
                    }
                    else if (numbers[startIndex] + numbers[endIndex] > target)
                    {
                        endIndex--;
                    }
                    else
                    {
                        startIndex++;
                    }
                }
                return null;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity :
 */
