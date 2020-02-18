/*
 * Problem 543: Reshape the Matrix
 * Difficulty: Easy
 * 
 * Given a binary tree, you need to compute the length of the diameter of the 
 * tree. The diameter of a binary tree is the length of the longest path 
 * between any two nodes in a tree. This path may or may not pass through 
 * the root.
 * 
 * Example:
 *  Given a binary tree
 * 
 *           1
 *          / \
 *         2   3
 *        / \     
 *       4   5    
 * 
 *  Return 3, which is the length of the path [4,2,1,3] or [5,2,1,3].
 * 
 * Note: The length of path between two nodes is represented by the number of 
 * 		 edges between them.
 */

using System;

namespace CSharpProblems
{
    public class Problem_543
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
            int result;
            public int DiameterOfBinaryTree(TreeNode root)
            {
                result = 0;
                Depth(root);
                return result;
            }

            private int Depth(TreeNode node)
            {
                if (node == null) { return 0; }
                int leftDepth = Depth(node.left);
                int rightDepth = Depth(node.right);
                result = Math.Max(result, leftDepth + rightDepth);
                return Math.Max(leftDepth, rightDepth) + 1;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(n). We visit every node once.
 * 		Space complexity : O(n), the size of our implicit call stack during 
 * 						   out depth-first search.
 */
