/*
 * Problem 559: Maximum Depth of N-ary Tree
 * Difficulty: Easy
 * 
 * Given a n-ary tree, find its maximum depth.
 * 
 * The maximum depth is the number of nodes along the longest path from the 
 * root node down to the farthest leaf node.
 * 
 * For example, given a 3-ary tree:
 * 
 *                      1
 *                    / | \
 *                   3  2  4
 *                  / \
 *                 5   6
 *  
 * We should return its max depth, which is 3.
 * 
 * Note:
 *     The depth of the tree is at most 1000.
 *     The total number of nodes is at most 5000.
 */

namespace CSharpProblems
{
    public class Problem_559
    {
        /*
        // Definition for a Node.
        public class Node {
            public int val;
            public IList<Node> children;

            public Node(){}
            public Node(int _val,IList<Node> _children) {
                val = _val;
                children = _children;
        }
        */
        public class Solution
        {
            public int MaxDepth(ChildrenNode root)
            {
                if (root == null)
                {
                    return 0;
                }

                int maxDepth = 1;
                for (int i = 0; i < root.children.Count; i++)
                {
                    int depth = 1 + MaxDepth(root.children[i]);

                    if (depth > maxDepth)
                    {
                        maxDepth = depth;
                    }
                }

                return maxDepth;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity : 
 */
