/*
 * Problem 106: Construct Binary Tree from Inorder and Postorder Traversal
 * Difficulty: Medium
 * 
 * Given inorder and postorder traversal of a tree, construct the binary tree.
 * 
 * Note: You may assume that duplicates do not exist in the tree.
 * 
 * For example, given
 *      inorder = [9,3,15,20,7]
 *      postorder = [9,15,7,20,3] 
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
    public class Problem_106
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
            public TreeNode BuildTree(int[] inorder, int[] postorder)
            {
                if (inorder == null || postorder == null ||
                    inorder.Length != postorder.Length)
                {
                    return null;
                }

                return Build(inorder, 0, (inorder.Length - 1),
                             postorder, 0, (postorder.Length - 1));
            }

            private TreeNode Build(int[] inorder, int inorderStart,
                                   int inorderEnd, int[] postorder,
                                   int postorderStart, int postorderEnd)
            {
                if (postorderStart > postorderEnd) { return null; }

                TreeNode node = new TreeNode(postorder[postorderEnd]);

                int inorderRoot = 0;
                for (int i = inorderStart; i <= inorderEnd; i++)
                {
                    if (postorder[postorderEnd] == inorder[i])
                    {
                        inorderRoot = i;
                        break;
                    }
                }
                int numberOfNodes = inorderRoot - inorderStart;

                node.left = Build(inorder, inorderStart, inorderRoot - 1,
                                  postorder, postorderStart,
                                  ((postorderStart + numberOfNodes) - 1));

                node.right = Build(inorder, inorderRoot + 1, inorderEnd,
                                   postorder, (postorderStart + numberOfNodes),
                                   postorderEnd - 1);

                return node;
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
