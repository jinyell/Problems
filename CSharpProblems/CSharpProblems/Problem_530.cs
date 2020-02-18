﻿/*
 * Problem 530: Minimum Absolute Difference in BST
 * Difficulty: Easy
 * 
 * Given a binary search tree with non-negative values, find the minimum 
 * absolute difference between values of any two nodes.
 * 
 * Example:
 *      Input:
 *         1
 *          \
 *           3
 *          /
 *         2
 * 
 * Output: 1
 * Explanation: The minimum absolute difference is 1, which is the difference 
 * 				between 2 and 1 (or between 2 and 3).
 * 
 * Note: There are at least two nodes in this BST.
 */

using System;

namespace CSharpProblems
{
    public class Problem_530
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
            public int GetMinimumDifference(TreeNode root)
            {
                int min = int.MaxValue;
                TreeNode prev = null;
                LevelOrder(root, ref prev, ref min);
                return min;
            }

            private void LevelOrder(TreeNode root, ref TreeNode prev,
                                    ref int min)
            {
                if (root == null)
                {
                    return;
                }

                LevelOrder(root.left, ref prev, ref min);

                if (prev != null)
                {
                    min = Math.Min(min, root.val - prev.val);
                }
                prev = root;

                LevelOrder(root.right, ref prev, ref min);
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity : 
 */
