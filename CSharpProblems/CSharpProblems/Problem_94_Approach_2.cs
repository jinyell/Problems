/*
 * Problem 94: Binary Tree Inorder Traversal
 * Difficulty: Medium
 * 
 * Given a binary tree, return the inorder traversal of its nodes' values.
 * 
 * Example:
 *      Input: [1,null,2,3]
 *         1
 *          \
 *           2
 *          /
 *         3
 * 
 *      Output: [1,3,2]
 *      Follow up: Recursive solution is trivial, could you do it iteratively?
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_94_Approach_2
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
            public IList<int> InorderTraversal(TreeNode root)
            {
                IList<int> inorder = new List<int>();
                Inorder(root, inorder);
                return inorder;
            }

            private void Inorder(TreeNode root, IList<int> inorder)
            {
                if (root == null)
                {
                    return;
                }

                Inorder(root.left, inorder);
                inorder.Add(root.val);
                Inorder(root.right, inorder);
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 
 * Time complexity : O(n). The time complexity is O(n) because the recursive 
 * 				     function is T(n)=2 * T(n/2)+1.
 * Space complexity: The worst case space required is O(n), and in the average 
 * 					 case it's O(log⁡n) where n is number of nodes. 
 */
