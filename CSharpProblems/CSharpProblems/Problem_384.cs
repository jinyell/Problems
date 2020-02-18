/*
 * Problem 384: Shuffle an Array
 * Difficulty: Medium
 *
 * Shuffle a set of numbers without duplicates.
 * 
 * Example:
 *      // Init an array with set 1, 2, and 3.
 *      int[] nums = {1,2,3};
 *      Solution solution = new Solution(nums);
 * 
 *      // Shuffle the array [1,2,3] and return its result. Any permutation of 
 * 		// [1,2,3] must equally likely to be returned.
 *      solution.shuffle();
 * 
 *      // Resets the array back to its original configuration [1,2,3].
 *      solution.reset();
 * 
 *      // Returns the random shuffling of array [1,2,3].
 *      solution.shuffle();
 */

using System;

namespace CSharpProblems
{
    public class Problem_384
    {
        public class Solution
        {
            private int[] nums;
            private Random rand;

            public Solution(int[] nums)
            {
                this.nums = nums;
                this.rand = new Random();
            }

            /** Resets the array to its original configuration & return it. */
            public int[] Reset()
            {
                return this.nums;
            }

            /** Returns a random shuffling of the array. */
            public int[] Shuffle()
            {
                if (this.nums == null || this.nums.Length <= 1)
                {
                    return this.nums;
                }

                int[] shuffleNums = new int[this.nums.Length];
                Array.Copy(this.nums, shuffleNums, this.nums.Length);
                int last = shuffleNums.Length - 1;

                for (int i = 1; i < shuffleNums.Length; i++)
                {
                    Swap(shuffleNums, rand.Next(0, last + 1), last);
                    last--;
                }
                return shuffleNums;
            }

            private void Swap(int[] arr, int loc1, int loc2)
            {
                int temp = arr[loc1];
                arr[loc1] = arr[loc2];
                arr[loc2] = temp;
            }
        }

        /**
         * Your Solution object will be instantiated and called as such:
         * Solution obj = new Solution(nums);
         * int[] param_1 = obj.Reset();
         * int[] param_2 = obj.Shuffle();
         */
    }
}

/*
 * Complexity Analysis:
 * 		Time complexity : 
 * 		Space complexity:
 */
