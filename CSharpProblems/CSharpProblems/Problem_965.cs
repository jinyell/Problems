/*
 * Problem 965: Univalued Binary Tree
 * Difficulty: Easy
 * 
 * A binary tree is univalued if every node in the tree has the same value.
 * 
 * Return true if and only if the given tree is univalued.
 * 
 * Example 1:
 *              1
 *             / \
 *            1   1
 *           / \   \
 *          1   1   1
 * 
 * Input: [1,1,1,1,1,null,1]
 * Output: true
 * 
 * Example 2:
 *              2
 *             / \
 *            2   2
 *           / \
 *          5   2
 * Input: [2,2,2,5,2]
 * Output: false
 * 
 * Note:
 *     The number of nodes in the given tree will be in the range [1, 100].
 *     Each node's value will be an integer in the range [0, 99].
 */

namespace CSharpProblems
{
    public class Problem_965
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
            public bool IsUnivalTree(TreeNode root)
            {
                bool leftUnivalued = (root.left == null ||
                    (root.val == root.left.val && IsUnivalTree(root.left)));
                bool rightUnivalued = (root.right == null ||
                    (root.val == root.right.val && IsUnivalTree(root.right)));
                return leftUnivalued && rightUnivalued;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(N), where N is the # of nodes in the given tree.
 * 		Space complexity : O(H), where H is the height of the given tree.
 */
