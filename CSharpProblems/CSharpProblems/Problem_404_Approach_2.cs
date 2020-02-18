/*
 * Problem 404: Sum of Left Leaves
 * Difficulty: Easy
 *
 * Find the sum of all left leaves in a given binary tree.
 * 
 * Example:
 * 
 *     3
 *    / \
 *   9  20
 *     /  \
 *    15   7
 * 
 * There are two left leaves in the binary tree, with values 9 and 15 
 * respectively. Return 24.
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_404_Approach_2
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
            public int SumOfLeftLeaves(TreeNode root)
            {
                if (root == null)
                {
                    return 0;
                }

                int res = 0;
                Stack<TreeNode> stack = new Stack<TreeNode>();
                stack.Push(root);

                while (stack.Count != 0)
                {
                    TreeNode node = stack.Pop();

                    if (node.left != null)
                    {
                        if (node.left.left == null && node.left.right == null)
                        {
                            res += node.left.val;
                        }
                        else
                        {
                            stack.Push(node.left);
                        }
                    }

                    if (node.right != null)
                    {
                        if (node.right.left != null ||
                            node.right.right != null)
                        {
                            stack.Push(node.right);
                        }
                    }
                }

                return res;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 		Time complexity : 
 * 		Space complexity:
 */
