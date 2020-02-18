/*
 * Problem 589: N-ary Tree Preorder Traversal
 * Difficulty: Easy
 * 
 * Given an n-ary tree, return the preorder traversal of its nodes' values.
 * 
 * For example, given a 3-ary tree:
 * 
 *                  1
 *                / | \
 *               3  2  4
 *              / \
 *             5   6
 * 
 * Return its preorder traversal as: [1,3,5,6,2,4].
 * 
 * Note: Recursive solution is trivial, could you do it iteratively?
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_589
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
            public IList<int> Preorder(ChildrenNode root)
            {
                IList<int> preorder = new List<int>();
                Traverse(root, preorder);
                return preorder;
            }

            private void Traverse(ChildrenNode node, IList<int> preorder)
            {
                if (node == null) { return; }

                preorder.Add(node.val);

                foreach (ChildrenNode currNode in node.children)
                {
                    Traverse(currNode, preorder);
                }
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity : 
 */
