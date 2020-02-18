/*
 * Problem 104: Maximum Depth of Binary Tree
 * Difficulty: Easy
 * 
 * Given a binary tree, find its maximum depth.
 * The maximum depth is the number of nodes along the longest path from the 
 * root node down to the farthest leaf node.
 * 
 * Note: A leaf is a node with no children.
 * 
 * Example:
 * Given binary tree [3,9,20,null,null,15,7],
 * 
 *     3
 *    / \
 *   9  20
 *     /  \
 *    15   7
 * 
 * return its depth = 3.
 */

using System;

namespace CSharpProblems
{
    public class Problem_104_Approach_2
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
            public int MaxDepth(TreeNode root)
            {
                return root == null ? 0
                                    : Math.Max(this.MaxDepth(root.left) + 1,
                                               this.MaxDepth(root.right) + 1);
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity : 
 */
