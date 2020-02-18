/*
 * Problem 669: Trim a Binary Search Tree
 * Difficulty: Easy
 * 
 * Given a binary search tree and the lowest and highest boundaries as L and R, 
 * trim the tree so that all its elements lies in [L, R] (R >= L). You might 
 * need to change the root of the tree, so the result should return the new 
 * root of the trimmed binary search tree.
 * 
 * Example 1:
 * 
 * Input: 
 *     1
 *    / \
 *   0   2
 * 
 *   L = 1
 *   R = 2
 * 
 * Output: 
 *     1
 *       \
 *        2
 * 
 * Example 2:
 * 
 * Input: 
 *     3
 *    / \
 *   0   4
 *    \
 *     2
 *    /
 *   1
 * 
 *   L = 1
 *   R = 3
 * 
 * Output: 
 *       3
 *      / 
 *    2   
 *   /
 *  1
 */

namespace CSharpProblems
{
    public class Problem_669
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
            public TreeNode TrimBST(TreeNode root, int L, int R)
            {
                if (root == null) { return root; }
                if (root.val > R) { return TrimBST(root.left, L, R); }
                if (root.val < L) { return TrimBST(root.right, L, R); }

                root.left = TrimBST(root.left, L, R);
                root.right = TrimBST(root.right, L, R);

                return root;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(n), where N is the total number of nodes in the 
 * 						   given tree. We visit each node at most once.
 * 		Space complexity : O(n). Even though we don't explicitly use any 
 * 						   additional memory, the call stack of our recursion 
 * 						   could be as large as the number of nodes in the 
 * 						   worst case.
 */
