/*
 * Problem 94: Binary Tree Inorder Traversal
 * Difficulty: Medium
 * 
 * Given a binary tree, return the inorder traversal of its nodes' values.
 * 
 * Example:
 *      Input: [1,null,2,3]
 *         1
 *          \
 *           2
 *          /
 *         3
 * 
 *      Output: [1,3,2]
 *      Follow up: Recursive solution is trivial, could you do it iteratively?
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_94
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
            public IList<int> InorderTraversal(TreeNode root)
            {
                IList<int> list = new List<int>();
                Stack<TreeNode> stack = new Stack<TreeNode>();
                TreeNode curr = root;

                while (curr != null || stack.Count != 0)
                {
                    while (curr != null)
                    {
                        stack.Push(curr);
                        curr = curr.left;
                    }

                    curr = stack.Pop();
                    list.Add(curr.val);
                    curr = curr.right;
                }
                return list;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 
 * Time complexity : O(n)
 * Space complexity: O(n)
 */
