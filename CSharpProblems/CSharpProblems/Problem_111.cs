/*
 * Problem 111: Minimum Depth of Binary Tree
 * Difficulty: Easy
 * 
 * Given a binary tree, find its minimum depth.
 * 
 * The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.
 * 
 * Note: A leaf is a node with no children.
 * 
 * Example:
 * 
 * Given binary tree [3,9,20,null,null,15,7],
 * 
 *     3
 *    / \
 *   9  20
 *     /  \
 *    15   7
 * 
 * return its minimum depth = 2.
 */

using System;

namespace CSharpProblems
{
    public class Problem_111
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
            public int MinDepth(TreeNode root)
            {
                if (root == null)
                {
                    return 0;
                }

                int left = MinDepth(root.left);
                int right = MinDepth(root.right);

                return 1 + (Math.Min(left, right) > 0 ? Math.Min(left, right) : Math.Max(left, right));
            }
        }
    }
}
