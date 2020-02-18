﻿/*
 * Problem 1022: Sum of Root To Leaf Binary Numbers
 * Difficulty: Easy
 * 
 * Given a binary tree, each node has value 0 or 1.  Each root-to-leaf 
 * path represents a binary number starting with the most significant bit.  
 * For example, if the path is 0 -> 1 -> 1 -> 0 -> 1, then this could 
 * represent 01101 in binary, which is 13.
 * 
 * For all leaves in the tree, consider the numbers represented by the path 
 * from the root to that leaf.
 * 
 * Return the sum of these numbers.
 * 
 * Example 1:
 * Input: [1,0,1,0,1,0,1]
 * Output: 22
 * Explanation: (100) + (101) + (110) + (111) = 4 + 5 + 6 + 7 = 22
 * 
 * Note:
 *     The number of nodes in the tree is between 1 and 1000.
 *     node.val is 0 or 1.
 *     The answer will not exceed 2^31 - 1.
 */

namespace CSharpProblems
{
    public class Problem_1022
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
            public int SumRootToLeaf(TreeNode root)
            {
                return DFS(root, 0);
            }

            private int DFS(TreeNode root, int val)
            {
                if (root == null) { return 0; }

                val = val * 2 + root.val;
                return root.left == root.right ? val
                                : DFS(root.left, val) + DFS(root.right, val);
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity :
 */
