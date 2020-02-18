/*
 * Problem 1089: Duplicate Zeros
 * Difficulty: Easy
 * 
 * Given a fixed length array arr of integers, duplicate each occurrence of 
 * zero, shifting the remaining elements to the right.
 * 
 * Note that elements beyond the length of the original array are not written.
 * 
 * Do the above modifications to the input array in place, do not return 
 * anything from your function.
 * 
 * Example 1:
 * Input: [1,0,2,3,0,4,5,0]
 * Output: null
 * Explanation: After calling your function, the input array is modified to: 
 * 				[1,0,0,2,3,0,0,4]
 * 
 * Example 2:
 * Input: [1,2,3]
 * Output: null
 * Explanation: 
 * After calling your function, the input array is modified to: [1,2,3]
 * 
 * Note:
 *     1 <= arr.length <= 10000
 *     0 <= arr[i] <= 9
 */

namespace CSharpProblems
{
    public class Problem_1089
    {
        public class Solution
        {
            public void DuplicateZeros(int[] arr)
            {
                int countZero = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 0)
                    {
                        countZero++;
                    }
                }

                int totalLength = arr.Length + countZero;

                for (int i = arr.Length - 1, j = totalLength - 1; i >= 0 && j >= 0; i--, j--)
                {
                    if (arr[i] != 0)
                    {
                        if (j < arr.Length)
                        {
                            arr[j] = arr[i];
                        }
                    }
                    else
                    {
                        if (j < arr.Length)
                        {
                            arr[j] = arr[i];
                        }
                        j--;
                        if (j < arr.Length)
                        {
                            arr[j] = arr[i];
                        }
                    }
                }
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity :
 */
