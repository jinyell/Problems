/*
 * Problem 1008: Construct Binary Search Tree from Preorder Traversal
 * Difficulty: Medium
 * 
 * Return the root node of a binary search tree that matches the given preorder traversal.
 * 
 * Recall that a binary search tree is a binary tree where for every node, 
 * any descendant of node.left has a value < node.val, 
 * and any descendant of node.right has a value > node.val.  
 * Also recall that a preorder traversal displays the value of the node first, 
 * then traverses node.left, then traverses node.right.)
 *  
 * Example 1:
 * Input: [8,5,1,7,10,12]
 * Output: [8,5,10,1,7,null,12]
 * 
 * Note: 
 *     1 <= preorder.length <= 100
 *     The values of preorder are distinct.
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_1008_Approach_3
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
            public TreeNode BstFromPreorder(int[] preorder)
            {
                if (preorder.Length == 0)
                {
                    return null;
                }

                Stack<TreeNode> stack = new Stack<TreeNode>();
                TreeNode root = new TreeNode(preorder[0]);
                stack.Push(root);

                for (int i = 1; i < preorder.Length; i++)
                {
                    TreeNode node = new TreeNode(preorder[i]);

                    if (preorder[i] < stack.Peek().val)
                    {
                        stack.Peek().left = node;
                    }
                    else
                    {
                        TreeNode parent = stack.Peek();

                        while (stack.Count != 0 && preorder[i] > stack.Peek().val)
                        {
                            parent = stack.Pop();
                        }
                        parent.right = node;
                    }

                    stack.Push(node);
                }

                return root;
            }
        }
    }
}
