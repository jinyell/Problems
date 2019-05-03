/*
 * Problem 654: Maximum Binary Tree
 * Difficulty: Medium
 * 
 * Given an integer array with no duplicates. A maximum tree building on this array is defined as follow:
 * 
 *     The root is the maximum number in the array.
 *     The left subtree is the maximum tree constructed from left part subarray divided by the maximum number.
 *     The right subtree is the maximum tree constructed from right part subarray divided by the maximum number.
 * 
 * Construct the maximum tree by the given array and output the root node of this tree.
 * 
 * Example 1:
 * Input: [3,2,1,6,0,5]
 * Output: return the tree root node representing the following tree:
 * 
 *       6
 *     /   \
 *    3     5
 *     \    / 
 *      2  0   
 *        \
 *         1
 * 
 * Note: The size of the given array will be in the range [1,1000].
 */

namespace CSharpProblems
{
    public class Problem_654
    {
        /**
         * Definition for a binary tree node.
         * public class TreeNode {
         *     public int val;
         *     public TreeNode left;
         *     public TreeNode right;
         *     public TreeNode(int x) { val = x; }
         * }
         */
        public class Solution
        {
            public TreeNode ConstructMaximumBinaryTree(int[] nums)
            {
                return MaxBinaryTree(nums, 0, nums.Length - 1);
            }

            private TreeNode MaxBinaryTree(int[] nums, int left, int right)
            {
                if (left > right)
                {
                    return null;
                }

                if (left == right)
                {
                    return new TreeNode(nums[left]);
                }

                int max = int.MinValue;
                int maxIndex = -1;

                for (int i = left; i <= right; i++)
                {
                    if (nums[i] > max)
                    {
                        max = nums[i];
                        maxIndex = i;
                    }
                }

                TreeNode root = new TreeNode(max);
                root.left = MaxBinaryTree(nums, left, maxIndex - 1);
                root.right = MaxBinaryTree(nums, maxIndex + 1, right);
                return root;
            }
        }
    }
}
