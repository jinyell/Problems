/*
 * Problem 95: Unique Binary Search Trees II
 * Difficulty: Medium
 * 
 * Given an integer n, generate all structurally unique BST's (binary 
 * search trees) that store values 1 ... n.
 * 
 * Example:
 *      Input: 3
 *      Output:
 *       [
 *        [1,null,3,2],
 *        [3,2,null,1],
 *        [3,1,null,null,2],
 *        [2,1,3],
 *        [1,null,2,null,3]
 *       ]
 *      Explanation:
 *          The above output corresponds to the 5 unique BST's shown below:
 * 
 *         1         3     3      2      1
 *          \       /     /      / \      \
 *           3     2     1      1   3      2
 *          /     /       \                 \
 *         2     1         2                 3
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_95
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
            public IList<TreeNode> GenerateTrees(int n)
            {
                if (n <= 0)
                {
                    return new List<TreeNode>();
                }

                return UniqueTrees(1, n);
            }

            private IList<TreeNode> UniqueTrees(int start, int end)
            {
                IList<TreeNode> list = new List<TreeNode>();

                if (start > end)
                {
                    list.Add(null);
                    return list;
                }

                if (start == end)
                {
                    list.Add(new TreeNode(start));
                    return list;
                }

                IList<TreeNode> left;
                IList<TreeNode> right;

                for (int i = start; i <= end; i++)
                {
                    left = UniqueTrees(start, i - 1);
                    right = UniqueTrees(i + 1, end);

                    for (int l = 0; l < left.Count; l++)
                    {
                        for (int r = 0; r < right.Count; r++)
                        {
                            TreeNode root = new TreeNode(i);
                            root.left = left[l];
                            root.right = right[r];
                            list.Add(root);
                        }
                    }
                }

                return list;
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
