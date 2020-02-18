/*
 * Problem 112: Path Sum
 * Difficulty: Easy
 * 
 * Given a binary tree and a sum, determine if the tree has a 
 * root-to-leaf path such that adding up all the values along 
 * the path equals the given sum.
 * 
 * Note: A leaf is a node with no children.
 * 
 * Example:
 * 
 * Given the below binary tree and sum = 22,
 * 
 *       5
 *      / \
 *     4   8
 *    /   / \
 *   11  13  4
 *  /  \      \
 * 7    2      1
 * 
 * return true, as there exist a root-to-leaf 
 * path 5->4->11->2 which sum is 22.
 */

namespace CSharpProblems
{
    public class Problem_112
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
            public bool HasPathSum(TreeNode root, int sum)
            {
                if (root == null)
                {
                    return false;
                }

                if (root.left == null && root.right == null)
                {
                    return root.val == sum;
                }

                return HasPathSum(root.left, sum - root.val) ||
                       HasPathSum(root.right, sum - root.val);
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity : 
 */
