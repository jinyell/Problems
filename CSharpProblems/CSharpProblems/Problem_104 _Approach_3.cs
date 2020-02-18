/*
 * Problem 104: Maximum Depth of Binary Tree
 * Difficulty: Easy
 * 
 * Given a binary tree, find its maximum depth.
 * The maximum depth is the number of nodes along the longest path from the 
 * root node down to the farthest leaf node.
 * 
 * Note: A leaf is a node with no children.
 * 
 * Example:
 * Given binary tree [3,9,20,null,null,15,7],
 * 
 *     3
 *    / \
 *   9  20
 *     /  \
 *    15   7
 * 
 * return its depth = 3.
 */

using System;
using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_104_Approach_3
    {
        /*
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
            public int MaxDepth(TreeNode root)
            {
                if (root == null)
                {
                    return 0;
                }

                Stack<TreeNode> stack = new Stack<TreeNode>();
                Stack<int> vals = new Stack<int>();
                int max = 0;

                stack.Push(root);
                vals.Push(1);

                while (stack.Count != 0)
                {
                    TreeNode node = stack.Pop();
                    int temp = vals.Pop();
                    max = Math.Max(temp, max);

                    if (node.right != null)
                    {
                        stack.Push(node.right);
                        vals.Push(temp + 1);
                    }

                    if (node.left != null)
                    {
                        stack.Push(node.left);
                        vals.Push(temp + 1);
                    }

                }

                return max;
            }
        }
    }
}

/*
 * Using DFS
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity : 
 */
