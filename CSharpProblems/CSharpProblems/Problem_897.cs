/*
 * Problem 897: Increasing Order Search Tree
 * Difficulty: Easy
 * 
 * Given a binary search tree, rearrange the tree in in-order so that the 
 * leftmost node in the tree is now the root of the tree, and every node 
 * has no left child and only 1 right child.
 * 
 * Example 1:
 * Input: [5,3,6,2,4,null,8,1,null,null,null,7,9]
 * 
 *        5
 *       / \
 *     3    6
 *    / \    \
 *   2   4    8
 *  /        / \ 
 * 1        7   9
 * 
 * Output: [1,null,2,null,3,null,4,null,5,null,6,null,7,null,8,null,9]
 * 
 *  1
 *   \
 *    2
 *     \
 *      3
 *       \
 *        4
 *         \
 *          5
 *           \
 *            6
 *             \
 *              7
 *               \
 *                8
 *                 \
 *                  9  
 * 
 * Note:
 *     The number of nodes in the given tree will be between 1 and 100.
 *     Each node will have a unique integer value from 0 to 1000.
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_897
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
            public TreeNode IncreasingBST(TreeNode root)
            {
                List<int> vals = new List<int>();
                Inorder(root, vals);

                TreeNode ans = new TreeNode(0);
                TreeNode curr = ans;

                for (int i = 0; i < vals.Count; i++)
                {
                    curr.right = new TreeNode(vals[i]);
                    curr = curr.right;
                }

                return ans.right;
            }

            private void Inorder(TreeNode node, List<int> vals)
            {
                if (node == null) { return; }
                Inorder(node.left, vals);
                vals.Add(node.val);
                Inorder(node.right, vals);
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(N), where N is the # of nodes in the given tree
 * 		Space complexity : O(N), the size of the answer
 */
