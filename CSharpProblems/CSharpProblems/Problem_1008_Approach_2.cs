/*
 * Problem 1008: Construct Binary Search Tree from Preorder Traversal
 * Difficulty: Medium
 * 
 * Return the root node of a binary search tree that matches the given 
 * preorder traversal.
 * 
 * Recall that a binary search tree is a binary tree where for every node, 
 * any descendant of node.left has a value < node.val, 
 * and any descendant of node.right has a value > node.val.  
 * Also recall that a preorder traversal displays the value of the node 
 * first, then traverses node.left, then traverses node.right.)
 *  
 * Example 1:
 * Input: [8,5,1,7,10,12]
 * Output: [8,5,10,1,7,null,12]
 * 
 *          8
 *         / \
 *        5   10
 *       / \    \
 *      1   7    12
 * 
 * Note: 
 *     1 <= preorder.length <= 100
 *     The values of preorder are distinct.
 */

namespace CSharpProblems
{
    public class Problem_1008_Approach_2
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
                int index = 0;
                return Preorder(preorder, int.MaxValue, ref index);
            }

            private TreeNode Preorder(int[] preorder, int bound, ref int index)
            {
                if (index == preorder.Length || preorder[index] > bound)
                {
                    return null;
                }

                TreeNode root = new TreeNode(preorder[index++]);
                root.left = Preorder(preorder, root.val, ref index);
                root.right = Preorder(preorder, bound, ref index);
                return root;
            }
        }
    }
}

/*
 * Complexity Analysis
 *      Time complexity :
 *      Space complexity:
 */