/*
 * Problem 105: Construct Binary Tree from Preorder and Inorder Traversal
 * Difficulty: Medium
 * 
 * Given preorder and inorder traversal of a tree, construct the binary tree.
 * 
 * Note: You may assume that duplicates do not exist in the tree.
 * 
 * For example, given
 *      preorder = [3,9,20,15,7]
 *      inorder = [9,3,15,20,7]
 * 
 *      Return the following binary tree:
 * 
 *          3
 *         / \
 *        9  20
 *          /  \
 *         15   7
 */

namespace CSharpProblems
{
    public class Problem_105
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
            public TreeNode BuildTree(int[] preorder, int[] inorder)
            {
                if (preorder == null || inorder == null || 
                    preorder.Length != inorder.Length)
                {
                    return null;
                }

                return Build(preorder, 0, (preorder.Length - 1), inorder, 0);
            }

            private TreeNode Build(int[] preorder, int preorderStart, 
                                   int preorderEnd, int[] inorder, 
                                   int inorderStart)
            {
                if (preorderStart > preorderEnd || 
                    preorderStart >= preorder.Length)
                {
                    return null;
                }

                TreeNode root = new TreeNode(preorder[preorderStart]);

                int inorderRoot = 0;
                for (int i = 0; i < inorder.Length; i++)
                {
                    if (preorder[preorderStart] == inorder[i])
                    {
                        inorderRoot = i;
                        break;
                    }
                }

                int preorderMid = preorderStart + inorderRoot - inorderStart;

                root.left = Build(preorder, (preorderStart + 1), 
                                  preorderMid, inorder, inorderStart);
                root.right = Build(preorder, (preorderMid + 1), 
                                   preorderEnd, inorder, (inorderRoot + 1));

                return root;
            }
        }
    }
}

/*
 * Complexity Analysis:
 * 
 * Time complexity :
 * Space complexity: 
 */
