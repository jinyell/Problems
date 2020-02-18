﻿/*
 * Problem 236: Lowest Common Ancestor of a Binary Tree
 * Difficulty: Medium
 * 
 * Given a binary tree, find the lowest common ancestor (LCA) of two given 
 * nodes in the tree.
 * 
 * According to the definition of LCA on Wikipedia: “The lowest common 
 * ancestor is defined between two nodes p and q as the lowest node in T that 
 * has both p and q as descendants (where we allow a node to be a descendant 
 * of itself).”
 * 
 * Given the following binary tree:  root = [3,5,1,6,2,0,8,null,null,7,4]
 * 
 *               3
 *             /   \
 *            5     1
 *           / \    / \
 *          6   2  0   8
 *             / \
 *            7   4
 *            
 * Example 1:
 *      Input: root = [3,5,1,6,2,0,8,null,null,7,4], p = 5, q = 1
 *      Output: 3
 *      Explanation: The LCA of nodes 5 and 1 is 3.
 * 
 * Example 2:
 *      Input: root = [3,5,1,6,2,0,8,null,null,7,4], p = 5, q = 4
 *      Output: 5
 *      Explanation: The LCA of nodes 5 and 4 is 5, since a node can be a 
 * 					 descendant of itself according to the LCA definition.
 * 
 * Note:
 *     All of the nodes' values will be unique.
 *     p and q are different and both values will exist in the binary tree.
 */

namespace CSharpProblems
{
    public class Problem_236
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
            public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p,
                                                 TreeNode q)
            {
                if (root == null || root == p || root == q) { return root; }
                TreeNode left = LowestCommonAncestor(root.left, p, q);
                TreeNode right = LowestCommonAncestor(root.right, p, q);
                return left == null ? right : right == null ? left : root;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 
 * 		Time complexity : O(N), where N is the number of nodes in the binary 
 * 						  tree. In the worst case we might be visiting all 
 * 						  the nodes of the binary tree.
 * 		Space complexity: O(N). This is because the maximum amount of space 
 * 						  utilized by the recursion stack would be N since 
 * 						  the height of a skewed binary tree could be N.
 */
