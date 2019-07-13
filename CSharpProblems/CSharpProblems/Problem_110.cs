/*
 * Problem 110: Balanced Binary Tree
 * Difficulty: Easy
 * 
 * Given a binary tree, determine if it is height-balanced.
 * For this problem, a height-balanced binary tree is defined as:
 *     a binary tree in which the depth of the two subtrees 
 *     of every node never differ by more than 1.
 * 
 * Example 1:
 * Given the following tree [3,9,20,null,null,15,7]:
 * 
 *     3
 *    / \
 *   9  20
 *     /  \
 *    15   7
 * Return true.
 * 
 * Example 2:
 * Given the following tree [1,2,2,3,3,null,null,4,4]:
 * 
 *        1
 *       / \
 *      2   2
 *     / \
 *    3   3
 *   / \
 *  4   4
 *  Return false.
 */

using System;

namespace CSharpProblems
{
    public class Problem_110
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
            public bool IsBalanced(TreeNode root)
            {
                if (root == null) { return true; }

                int left = Depth(root.left);
                int right = Depth(root.right);

                return Math.Abs(left - right) <= 1 &&
                    IsBalanced(root.left) && IsBalanced(root.right);
            }

            private int Depth(TreeNode root)
            {
                if (root == null) { return 0; }

                int left = root.left == null ? 0 : Depth(root.left);
                int right = root.right == null ? 0 : Depth(root.right);
                return Math.Max(left, right) + 1;
            }
        }
    }
}
