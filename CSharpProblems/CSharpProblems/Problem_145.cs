/*
 * Problem 145: Binary Tree Postorder Traversal
 * Difficulty: Hard
 * 
 * Given a binary tree, return the postorder traversal of its nodes' values.
 * 
 * Example:
 *      Input: [1,null,2,3]
 *         1
 *          \
 *           2
 *          /
 *         3
 * 
 *      Output: [3,2,1]
 * 
 * Follow up: Recursive solution is trivial, could you do it iteratively?
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_145
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
            public IList<int> PostorderTraversal(TreeNode root)
            {
                IList<int> list = new List<int>();

                if (root == null) { return list; }

                Stack<TreeNode> stack = new Stack<TreeNode>();
                stack.Push(root);

                while (stack.Count > 0)
                {
                    root = stack.Pop();
                    list.Insert(0, root.val);
                    if (root.left != null)
                    {
                        stack.Push(root.left);
                    }

                    if (root.right != null)
                    {
                        stack.Push(root.right);
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
