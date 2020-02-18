/*
 * Problem 100: Same Tree
 * Difficulty: Easy
 * 
 * Given two binary trees, write a function to check if they are the same 
 * or not. Two binary trees are considered the same if they are 
 * structurally identical and the nodes have the same value.
 * 
 * Example 1:
 * 
 * Input:     1         1
 *           / \       / \
 *          2   3     2   3
 * 
 *         [1,2,3],   [1,2,3]
 * 
 * Output: true
 * 
 * Example 2:
 * 
 * Input:     1         1
 *           /           \
 *          2             2
 * 
 *         [1,2],     [1,null,2]
 * 
 * Output: false
 * 
 * Example 3:
 * 
 * Input:     1         1
 *           / \       / \
 *          2   1     1   2
 * 
 *         [1,2,1],   [1,1,2]
 * 
 * Output: false
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_100
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
            public bool IsSameTree(TreeNode p, TreeNode q)
            {
                if (p == null && q == null)
                {
                    return true;
                }

                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(p);
                queue.Enqueue(q);

                while (queue.Count > 0)
                {
                    TreeNode first = queue.Dequeue();
                    TreeNode second = queue.Dequeue();

                    if (first == null && second == null)
                    {
                        continue;
                    }

                    if (first == null || second == null ||
                      first.val != second.val)
                    {
                        return false;
                    }

                    queue.Enqueue(first.left);
                    queue.Enqueue(second.left);
                    queue.Enqueue(first.right);
                    queue.Enqueue(second.right);
                }

                return true;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 
 * Time complexity : O(N) since each node is visited exactly once.
 * Space complexity : O(log⁡(N)) in the best case of completely balanced 
 * tree and O(N) in the worst case of completely unbalanced tree, 
 * to keep a deque.
*/
