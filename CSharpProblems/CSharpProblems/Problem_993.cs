/*
 * Problem 993: Cousins in Binary Tree
 * Difficulty: Easy
 * 
 * In a binary tree, the root node is at depth 0, and children of each 
 * depth k node are at depth k+1.
 * 
 * Two nodes of a binary tree are cousins if they have the same depth, 
 * but have different parents.
 * 
 * We are given the root of a binary tree with unique values, and the values x 
 * and y of two different nodes in the tree.
 * 
 * Return true if and only if the nodes corresponding to the values x and 
 * y are cousins.
 * 
 * Example 1:
 *              1
 *             / \
 *            2   3
 *           /
 *          4
 * Input: root = [1,2,3,4], x = 4, y = 3
 * Output: false
 * 
 * Example 2:
 *              1
 *             / \
 *            2   3
 *             \   \
 *             4    5
 * Input: root = [1,2,3,null,4,null,5], x = 5, y = 4
 * Output: true
 * 
 * Example 3:
 *              1
 *             / \
 *            2   3
 *             \
 *              4
 * Input: root = [1,2,3,null,4], x = 2, y = 3
 * Output: false
 * 
 * Note:
 *     The number of nodes in the tree will be between 2 and 100.
 *     Each node has a unique integer value from 1 to 100.
 */

namespace CSharpProblems
{
    public class Problem_993
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
            public bool IsCousins(TreeNode root, int x, int y)
            {
                return FindDepth(root, x, 1) == FindDepth(root, y, 1) &&
                                !IsSibling(root, x, y);
            }

            private bool IsSibling(TreeNode node, int x, int y)
            {
                if (node == null)
                {
                    return false;
                }

                bool check = false;
                if (node.left != null && node.right != null)
                {
                    check = (node.left.val == x && node.right.val == y) ||
                            (node.left.val == y && node.right.val == x);
                }

                return check || IsSibling(node.left, x, y) ||
                       IsSibling(node.right, x, y);
            }

            private int FindDepth(TreeNode node, int val, int height)
            {
                if (node == null)
                {
                    return 0;
                }

                if (node.val == val)
                {
                    return height;
                }

                return FindDepth(node.left, val, height + 1) |
                       FindDepth(node.right, val, height + 1);
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity :
 */
