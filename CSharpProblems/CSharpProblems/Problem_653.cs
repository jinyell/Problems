/*
 * Problem 653: Two Sum IV - Input is a BST
 * Difficulty: Easy
 * 
 * Given a Binary Search Tree and a target number, return true if there exist 
 * two elements in the BST such that their sum is equal to the given target.
 * 
 * Example 1:
 * 
 * Input: 
 *     5
 *    / \
 *   3   6
 *  / \   \
 * 2   4   7
 * 
 * Target = 9
 * 
 * Output: True
 * 
 * Example 2:
 * 
 * Input: 
 *     5
 *    / \
 *   3   6
 *  / \   \
 * 2   4   7
 * 
 * Target = 28
 * 
 * Output: False
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_653
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
            public bool FindTarget(TreeNode root, int k)
            {
                HashSet<int> hs = new HashSet<int>();
                return Search(root, k, hs);
            }

            private bool Search(TreeNode root, int k, HashSet<int> hs)
            {
                if (root == null)
                {
                    return false;
                }

                if (hs.Contains(k - root.val))
                {
                    return true;
                }

                hs.Add(root.val);

                return Search(root.left, k, hs) || Search(root.right, k, hs);
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(n). The entire tree is traversed only once in the 
 * 						   worst case. Here, n refers to the number of nodes 
 * 						   in the given tree.
 * 		Space complexity : O(n). The size of the set can grow up to n in the 
 * 						   worst case.
 */
