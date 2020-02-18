/*
 * Problem 100: Same Tree
 * Difficulty: Easy
 * 
 * Given two binary trees, write a function to check if they are the 
 * same or not.
 * Two binary trees are considered the same if they are structurally 
 * identical and the nodes have the same value.
 * 
 * Example 1:
 * 
 * Input:     1         1
 *           / \       / \
 *          2   3     2   3
 * 
 *         [1,2,3],   [1,2,3]
 * 
 * Output: true
 * 
 * Example 2:
 * 
 * Input:     1         1
 *           /           \
 *          2             2
 * 
 *         [1,2],     [1,null,2]
 * 
 * Output: false
 * 
 * Example 3:
 * 
 * Input:     1         1
 *           / \       / \
 *          2   1     1   2
 * 
 *         [1,2,1],   [1,1,2]
 * 
 * Output: false
 */

namespace CSharpProblems
{
    public class Problem_100_Approach_2
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
            public bool IsSameTree(TreeNode p, TreeNode q)
            {
                if (p == null && q == null)
                {
                    return true;
                }

                if (p == null || q == null)
                {
                    return false;
                }

                if (p.val != q.val)
                {
                    return false;
                }

                return IsSameTree(p.left, q.left) &&
                       IsSameTree(p.right, q.right);
            }
        }
    }
}
/*
 * Complexity Analysis
 * Time complexity : O(N), where N is a number of nodes in the tree, 
 * 					 since one visits each node exactly once.
 * Space complexity: O(log⁡(N)) in the best case of completely balanced 
 * 					 tree and O(N) in the worst case of completely 
 * 					 unbalanced tree, to keep a recursion stack.
 */