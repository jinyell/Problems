/*
 * Problem 230: Kth Smallest Element in a BST
 * Difficulty: Medium
 * 
 * Given a binary search tree, write a function kthSmallest to find the 
 * kth smallest element in it.
 * 
 * Note: You may assume k is always valid, 1 ≤ k ≤ BST's total elements.
 * 
 * Example 1:
 *      Input: root = [3,1,4,null,2], k = 1
 *         3
 *        / \
 *       1   4
 *            \
 *             2
 *      Output: 1
 * 
 * Example 2:
 *      Input: root = [5,3,6,2,4,null,null,1], k = 3
 *             5
 *            / \
 *           3   6
 *          / \
 *         2   4
 *        /
 *       1
 * Output: 3
 * 
 * Follow up: What if the BST is modified (insert/delete operations) 
 * often and you need to find the kth smallest frequently? How would you 
 * optimize the kthSmallest routine?
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_230_Approach_2
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
            public int KthSmallest(TreeNode root, int k)
            {
                Stack<TreeNode> stack = new Stack<TreeNode>();

                while (true)
                {
                    while (root != null)
                    {
                        stack.Push(root);
                        root = root.left;
                    }

                    root = stack.Pop();

                    if (--k == 0)
                    {
                        return root.val;
                    }
                    root = root.right;
                }
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 
 * 		Time complexity : O(H + k), where H is a tree height. This complexity 
 * 			is defined by the stack, which contains at least H + k elements, 
 * 			since before starting to pop out one has to go down to a leaf. 
 * 			This results O(log N + k) for the balanced tree and O(N + k) for 
 * 			completely unbalanced tree with all the nodes in teh left subtree.
 * 		Space complexity: O(H + k), the same as for the time complexity, 
 * 			O(N + k) in the worst case, and O(log N + k) in the average case.
 */
