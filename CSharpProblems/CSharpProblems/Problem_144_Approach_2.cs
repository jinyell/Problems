/*
 * Problem 144: Binary Tree Preorder Traversal
 * Difficulty: Medium
 * 
 * Given a binary tree, return the preorder traversal of its nodes' values.
 * 
 * Example:
 *      Input: [1,null,2,3]
 *         1
 *          \
 *           2
 *          /
 *         3
 * 
 *      Output: [1,2,3]
 * 
 * Follow up: Recursive solution is trivial, could you do it iteratively?
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_144_Approach_2
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
            public IList<int> PreorderTraversal(TreeNode root)
            {
                IList<int> preorder = new List<int>();
                PreOrder(root, preorder);
                return preorder;
            }

            private void PreOrder(TreeNode root, IList<int> preorder)
            {
                if (root == null)
                {
                    return;
                }
                preorder.Add(root.val);
                PreOrder(root.left, preorder);
                PreOrder(root.right, preorder);
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity : 
 */
