/*
 * Problem 230: Kth Smallest Element in a BST
 * Difficulty: Medium
 * 
 * Given a binary search tree, write a function kthSmallest to find the kth smallest element in it.
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
 * Follow up: What if the BST is modified (insert/delete operations) often and you need to find the kth smallest frequently? How would you optimize the kthSmallest routine?
 */

namespace CSharpProblems
{
    public class Problem_230
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
            int count = 0;
            int result = int.MinValue;

            public int KthSmallest(TreeNode root, int k)
            {
                Traverse(root, k);
                return result;
            }

            public void Traverse(TreeNode root, int k)
            {
                if (root == null)
                {
                    return;
                }

                Traverse(root.left, k);
                count++;

                if (count == k)
                {
                    result = root.val;
                }

                Traverse(root.right, k);
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 
 * 		Time complexity : O(n) to build a traversal
 * 		Space complexity: O(n) to keep inorder traversal
 */
