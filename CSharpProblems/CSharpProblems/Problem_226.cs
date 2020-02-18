/*
 * Problem 226: Invert Binary Tree
 * Difficulty: Easy
 * 
 * Invert a binary tree.
 * 
 * Example:
 *      Input:
 * 
 *           4
 *         /   \
 *        2     7
 *       / \   / \
 *      1   3 6   9
 * 
 *      Output:
 * 
 *           4
 *         /   \
 *        7     2
 *       / \   / \
 *      9   6 3   1
 */

namespace CSharpProblems
{
    public class Problem_226
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
            public TreeNode InvertTree(TreeNode root)
            {
                if (root == null)
                {
                    return null;
                }

                TreeNode right = InvertTree(root.right);
                TreeNode left = InvertTree(root.left);

                root.left = right;
                root.right = left;

                return root;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 
 * 		Time complexity : O(n). Since each node in the tree is visited only once, the time complexity is O(n), where n is the number of nodes in the tree. We cannot do better than that, since at the very least we have to visit each node to invert it.
 * 		Space complexity: O(n). Because of recursion, O(h) function calls will be placed on the stack in the worst case, where h is the heigh of the tree. Because h ∈ O(n), the space complexity is O(n)
 */
