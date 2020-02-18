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

namespace CSharpProblems
{
    public class Problem_538_Approach_3
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
            private TreeNode GetSuccessor(TreeNode node)
            {
                TreeNode succ = node.right;

                while (succ.left != null && succ.left != node)
                {
                    succ = succ.left;
                }

                return succ;
            }

            public TreeNode ConvertBST(TreeNode root)
            {
                int sum = 0;
                TreeNode node = root;

                while (node != null)
                {
                    if (node.right == null)
                    {
                        sum += node.val;
                        node.val = sum;
                        node = node.left;
                    }
                    else
                    {
                        TreeNode succ = GetSuccessor(node);

                        if (succ.left == null)
                        {
                            succ.left = node;
                            node = node.right;
                        }
                        else
                        {
                            succ.left = null;
                            sum += node.val;
                            node.val = sum;
                            node = node.left;
                        }
                    }
                }

                return root;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(n) Although the Morris traversal does slightly 
 * 			more work than the other approaches, it is only by a constant 
 * 			factor. To be specific, if we can show that each edge in the tree 
 * 			is traversed no more than kkk times (for some constant kkk), then 
 * 			the algorithm is shown to have linear time complexity. First, note 
 * 			that getSuccessor is called at most twice per node. On the first 
 * 			invocation, the temporary link back to the node in question is 
 * 			created, and on the second invocation, the temporary link is 
 * 			erased. Then, the algorithm steps into the left subtree with no 
 * 			way to return to the node. Therefore, each edge can only be 
 * 			traversed 3 times: once when we move the node pointer, and once 
 * 			for each of the two calls to getSuccessor.
 * 		Space complexity : O(n) Because we only manipulate pointers that 
 * 			already exist, the Morris traversal uses constant space.
 */
