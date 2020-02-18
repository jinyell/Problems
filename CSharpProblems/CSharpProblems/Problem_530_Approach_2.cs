/*
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
using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_530_Approach_2
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
                Stack<TreeNode> stack = new Stack<TreeNode>();
                TreeNode current = root;
                TreeNode previous = null;

                while (current != null || stack.Count != 0)
                {
                    if (current != null)
                    {
                        stack.Push(current);
                        current = current.left;
                    }
                    else
                    {
                        current = stack.Pop();
                        if (previous != null)
                        {
                            min = Math.Min(min, current.val - previous.val);
                        }
                        previous = current;
                        current = current.right;
                    }
                }
                return min;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity : 
 */
