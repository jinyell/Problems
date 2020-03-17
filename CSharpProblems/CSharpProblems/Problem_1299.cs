/*
 * Problem 1299: Replace Elements with Greatest Element on Right Side
 * Difficulty: Easy
 * 
 * Given an array arr, replace every element in that array with the greatest element among the elements to its right, and replace the last element with -1.
 * 
 * After doing so, return the array.
 * 
 * Example 1:
 *      Input: arr = [17,18,5,4,6,1]
 *      Output: [18,6,6,6,1,-1]
 *  
 * Constraints:
 *      1 <= arr.length <= 10^4
 *      1 <= arr[i] <= 10^5
 */

namespace CSharpProblems
{
    public class Problem_1299
    {
        public class Solution
        {
            public int[] ReplaceElements(int[] arr)
            {
                int max = -1;
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    int temp = arr[i];
                    arr[i] = max;
                    if (temp > max)
                    {
                        max = temp;
                    }
                }

                return arr;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity :
 */