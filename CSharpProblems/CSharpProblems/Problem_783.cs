/*
 * Problem 783: Minimum Distance Between BST Nodes
 * Difficulty: Easy
 * 
 * Given a Binary Search Tree (BST) with the root node root, return the 
 * minimum difference between the values of any two different nodes in 
 * the tree.
 * 
 * Example :
 * 
 * Input: root = [4,2,6,1,3,null,null]
 * Output: 1
 * Explanation: Note that root is a TreeNode object, not an array.
 * 
 * The given tree [4,2,6,1,3,null,null] is represented by the following diagram:
 * 
 *           4
 *         /   \
 *       2      6
 *      / \    
 *     1   3  
 * while the minimum difference in this tree is 1, it occurs between node 1 
 * and node 2, also between node 3 and node 2.
 * 
 * Note:
 *     - The size of the BST will be between 2 and 100.
 *     - The BST is always valid, each node's value is an integer, and each 
 * 		 node's value is different.
 */

using System;

namespace CSharpProblems
{
    public class Problem_783
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
            private int min = int.MaxValue;

            public int MinDiffInBST(TreeNode root)
            {
                if (root != null)
                {
                    TreeNode node = root.left;

                    while (node != null && node.right != null)
                    {
                        node = node.right;
                    }

                    if (node != null)
                    {
                        min = Math.Min(min, Math.Abs(root.val - node.val));
                    }

                    node = root.right;

                    while (node != null && node.left != null)
                    {
                        node = node.left;
                    }

                    if (node != null)
                    {
                        min = Math.Min(min, Math.Abs(root.val - node.val));
                    }

                    MinDiffInBST(root.left);
                    MinDiffInBST(root.right);
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
