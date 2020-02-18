/*
 * Problem 226: Invert Binary Tree
 * Difficulty: Easy
 * 
 * Invert a binary tree.
 * 
 * Example:
 *      Input:
 * 
 *           4
 *         /   \
 *        2     7
 *       / \   / \
 *      1   3 6   9
 * 
 *      Output:
 * 
 *           4
 *         /   \
 *        7     2
 *       / \   / \
 *      9   6 3   1
 */

namespace CSharpProblems
{
    public class Problem_226_Approach_2
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
            public TreeNode InvertTree(TreeNode root)
            {
                if (root == null)
                {
                    return null;
                }

                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(root);

                while (queue.Count != 0)
                {
                    TreeNode current = queue.Dequeue();
                    TreeNode temp = current.left;
                    current.left = current.right;
                    current.right = temp;

                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }

                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }
                }

                return root;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 
 * 		Time complexity : O(n). Since each node in the tree is visited / 
 * 						  added to the queue only once.
 * 		Space complexity: O(n). Worst case the queue will contain all nodes 
 * 						  in one level of the binary tree. For a full binary 
 * 						  tree, the leaf level has n/2 = O(n) leaves
 */
