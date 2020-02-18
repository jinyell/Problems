/*
 * Problem 297: Serialize and Deserialize Binary Tree
 * Difficulty: Hard
 *
 * Serialization is the process of converting a data structure or object 
 * into a sequence of bits so that it can be stored in a file or memory 
 * buffer, or transmitted across a network connection link to be reconstructed 
 * later in the same or another computer environment.
 * 
 * Design an algorithm to serialize and deserialize a binary tree. There is 
 * no restriction on how your serialization/deserialization algorithm should 
 * work. You just need to ensure that a binary tree can be serialized to a 
 * string and this string can be deserialized to the original tree structure.
 * 
 * Example: 
 * 
 * You may serialize the following tree:
 * 
 *     1
 *    / \
 *   2   3
 *      / \
 *     4   5
 * 
 * as "[1,2,3,null,null,4,5]"
 * 
 * Clarification: The above format is the same as how LeetCode serializes a 
 * 				  binary tree. You do not necessarily need to follow this 
 * 				  format, so please be creative and come up with different 
 * 				  approaches yourself.
 * 
 * Note: Do not use class member/global/static variables to store states. Your 
 * 		 serialize and deserialize algorithms should be stateless.
 */

using System;
using System.Text;

namespace CSharpProblems
{
    public class Problem_297
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
        public class Codec
        {

            // Encodes a tree to a single string.
            public string serialize(TreeNode root)
            {
                return SerializeTraverse(root, new StringBuilder()).ToString();
            }

            private StringBuilder SerializeTraverse(TreeNode root,
                                                    StringBuilder sb)
            {
                if (root == null)
                {
                    sb.Append("null,");
                }
                else
                {
                    sb.Append(root.val + ",");
                    SerializeTraverse(root.left, sb);
                    SerializeTraverse(root.right, sb);
                }
                return sb;
            }

            // Decodes your encoded data to tree.
            public TreeNode deserialize(string data)
            {
                return DeserializeTraversal(new int[1], data.Split(','));
            }

            private TreeNode DeserializeTraversal(int[] index, string[] split)
            {
                if (split[index[0]] == "null")
                {
                    return null;
                }

                TreeNode root = new TreeNode(Int32.Parse(split[index[0]]));
                index[0]++;
                root.left = DeserializeTraversal(index, split);
                index[0]++;
                root.right = DeserializeTraversal(index, split);
                return root;
            }
        }

        // Your Codec object will be instantiated and called as such:
        // Codec codec = new Codec();
        // codec.deserialize(codec.serialize(root));
    }
}

/*
 * Complexity Analysis:
 * 		Time complexity :
 * 		Space complexity:
 */
