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
    public class Problem_144
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
                List<int> list = new List<int>();

                if (root == null) { return list; }
                Stack<TreeNode> stack = new Stack<TreeNode>();
                stack.Push(root);

                while (stack.Count > 0)
                {
                    root = stack.Pop();
                    list.Add(root.val);

                    if (root.right != null)
                    {
                        stack.Push(root.right);
                    }

                    if (root.left != null)
                    {
                        stack.Push(root.left);
                    }
                }
                return list;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity : 
 */
