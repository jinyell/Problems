/*
 * Problem 538: Convert BST to Greater Tree
 * Difficulty: Easy
 * 
 * Given a Binary Search Tree (BST), convert it to a Greater Tree such that 
 * every key of the original BST is changed to the original key plus sum of 
 * all keys greater than the original key in BST.
 * 
 * Example:
 *      Input: The root of a Binary Search Tree like this:
 *               5
 *             /   \
 *            2     13
 * 
 *      Output: The root of a Greater Tree like this:
 *               18
 *             /    \
 *           20      13
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_538_Approach_2
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
            public TreeNode ConvertBST(TreeNode root)
            {
                int sum = 0;
                TreeNode node = root;
                Stack<TreeNode> stack = new Stack<TreeNode>();

                while (stack.Count != 0 || node != null)
                {
                    while (node != null)
                    {
                        stack.Push(node);
                        node = node.right;
                    }

                    node = stack.Pop();
                    sum += node.val;
                    node.val = sum;

                    node = node.left;
                }

                return root;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(n) The key observation is that each node is pushed 
 * 			onto the stack exactly once. I will take for granted the assumption 
 * 			that a node will always be pushed at least once, as the alternative 
 * 			would imply that at least one node is disconnected from the root. 
 * 			Notice that nodes are only pushed onto the stack when they are 
 * 			pointed to by node at the beginning of the outer while loop, or 
 * 			when there is a path to them from such a node by using only right 
 * 			pointers. Then notice that at the end of each iteration of the 
 * 			loop, node points to the left child of a node that has been pushed 
 * 			onto (and subsequently popped from) the stack. Therefore, because 
 * 			the outer while loop always begins with node pointing to None, the 
 * 			root (which is not pointed to by any other node), or a left child 
 * 			of a visited node, we cannot revisit nodes.
 * 		Space complexity : O(n) If we assume that the above logic is sound, 
 * 			the assertion that each node is pushed onto the stack exactly once 
 * 			implies that the stack can contain (at most) nnn nodes. All other 
 * 			parts of the algorithm use constant space, so there is overall a 
 * 			linear memory footprint.
 */
