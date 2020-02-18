/*
 * Problem 101: Symmetric Tree
 * Difficulty: Easy
 * 
 * Given a binary tree, check whether it is a mirror of itself (ie, symmetric 
 * around its center).
 * 
 * For example, this binary tree [1,2,2,3,4,4,3] is symmetric:
 * 
 *     1
 *    / \
 *   2   2
 *  / \ / \
 * 3  4 4  3
 * 
 * But the following [1,2,2,null,3,null,3] is not:
 * 
 *     1
 *    / \
 *   2   2
 *    \   \
 *    3    3
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_101_Approach_2
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
            public bool IsSymmetric(TreeNode root)
            {
                if (root == null)
                {
                    return true;
                }

                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(root.left);
                queue.Enqueue(root.right);

                while (queue.Count != 0)
                {
                    TreeNode leftNode = queue.Dequeue();
                    TreeNode rightNode = queue.Dequeue();

                    if (leftNode == null && rightNode == null)
                    {
                        continue;
                    }

                    if (leftNode == null || rightNode == null ||
                       leftNode.val != rightNode.val)
                    {
                        return false;
                    }

                    queue.Enqueue(leftNode.left);
                    queue.Enqueue(rightNode.right);

                    queue.Enqueue(leftNode.right);
                    queue.Enqueue(rightNode.left);
                }

                return true;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(n). Because we traverse the entire input tree 
 * 						   once, the total run time is O(n), where n is the 
 * 						   total number of nodes in the tree.
 * 		Space complexity : There is additional space required for the search 
 * 						   queue. In the worst case, we have to insert O(n) 
 *						   nodes in the queue. Therefore, space 
 *						   complexity is O(n).
 */
