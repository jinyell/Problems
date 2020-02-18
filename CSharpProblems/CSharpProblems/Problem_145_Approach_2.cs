/*
 * Problem 145: Binary Tree Postorder Traversal
 * Difficulty: Hard
 * 
 * Given a binary tree, return the postorder traversal of its nodes' values.
 * 
 * Example:
 *      Input: [1,null,2,3]
 *         1
 *          \
 *           2
 *          /
 *         3
 * 
 *      Output: [3,2,1]
 * 
 * Follow up: Recursive solution is trivial, could you do it iteratively?
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_145_Approach_2
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

        public class Solution {
            public IList<int> PostorderTraversal(TreeNode root) {
                IList<int> postorder = new List<int>();
                Postorder(root, postorder);
                return postorder;
            }

            private void Postorder(TreeNode root, IList<int> postorder)
            {
                if(root == null) {
                    return;
                }

                Postorder(root.left, postorder);
                Postorder(root.right, postorder);
                postorder.Add(root.val);
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity : 
 */
