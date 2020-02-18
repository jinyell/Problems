/*
 * Problem 832: Shortest Distance to a Character
 * Difficulty: Easy
 * 
 * Given a binary matrix A, we want to flip the image horizontally, then 
 * invert it, and return the resulting image.
 * 
 * To flip an image horizontally means that each row of the image is reversed.  
 * For example, flipping [1, 1, 0] horizontally results in [0, 1, 1].
 * 
 * To invert an image means that each 0 is replaced by 1, and each 1 is 
 * replaced by 0. For example, inverting [0, 1, 1] results in [1, 0, 0].
 * 
 * Example 1:
 * 
 * Input: [[1,1,0],[1,0,1],[0,0,0]]
 * Output: [[1,0,0],[0,1,0],[1,1,1]]
 * Explanation: First reverse each row: [[0,1,1],[1,0,1],[0,0,0]].
 * Then, invert the image: [[1,0,0],[0,1,0],[1,1,1]]
 * 
 * Example 2:
 * 
 * Input: [[1,1,0,0],[1,0,0,1],[0,1,1,1],[1,0,1,0]]
 * Output: [[1,1,0,0],[0,1,1,0],[0,0,0,1],[1,0,1,0]]
 * Explanation: 
 * First reverse each row: [[0,0,1,1],[1,0,0,1],[1,1,1,0],[0,1,0,1]].
 * Then invert the image: [[1,1,0,0],[0,1,1,0],[0,0,0,1],[1,0,1,0]]
 * 
 * Notes:
 *     1 <= A.length = A[0].length <= 20
 *     0 <= A[i][j] <= 1
 */

namespace CSharpProblems
{
    public class Problem_832
    {
        public class Solution
        {
            public int[][] FlipAndInvertImage(int[][] A)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    ReverseArray(A[i]);

                    for (int j = 0; j < A[i].Length; j++)
                    {
                        A[i][j] = (A[i][j] == 0) ? 1 : 0;
                    }
                }
                return A;
            }

            private void ReverseArray(int[] arr)
            {
                int low = 0;
                int high = arr.Length - 1;

                while (low < high)
                {
                    int temp = arr[low];
                    arr[low] = arr[high];
                    arr[high] = temp;
                    low++;
                    high--;
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
