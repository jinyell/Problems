/*
 * Problem 637: Average of Levels in Binary Tree
 * Difficulty: Easy
 * 
 * Given a non-empty binary tree, return the average value of the nodes on each 
 * level in the form of an array.
 * 
 * Example 1:
 * 
 * Input:
 *     3
 *    / \
 *   9  20
 *     /  \
 *    15   7
 * Output: [3, 14.5, 11]
 * Explanation:
 * The average value of nodes on level 0 is 3,  on level 1 is 14.5, and on 
 * level 2 is 11. Hence return [3, 14.5, 11].
 * 
 * Note: The range of node's value is in the range of 32-bit signed integer.

 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_637
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
            public IList<double> AverageOfLevels(TreeNode root)
            {
                List<int> count = new List<int>();
                List<double> result = new List<double>();

                SumDFS(root, 0, result, count);

                for (int i = 0; i < result.Count; i++)
                {
                    result[i] = (result[i] / count[i]);
                }

                return result;
            }

            private void SumDFS(TreeNode node, int index, List<double> sum,
                                List<int> count)
            {
                if (node == null) { return; }

                if (index < sum.Count)
                {
                    sum[index] = sum[index] + node.val;
                    count[index]++;
                }
                else
                {
                    sum.Add(1.0 * node.val);
                    count.Add(1);
                }

                SumDFS(node.left, index + 1, sum, count);
                SumDFS(node.right, index + 1, sum, count);
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : O(n). The whole tree is traversed once only. Here, 
 * 				n refers to the total number of nodes in the given binary tree.
 * 		Space complexity : O(h). res and count array of size h are used. Here, 
 * 				h refers to the heigh (max numbers of levels) of the given 
 * 				binary tree. Further, the depth of the recursive tree could go 
 * 				up to h only
 */
