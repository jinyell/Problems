/*
 * Problem 703: Kth Largest Element in a Stream
 * Difficulty: Easy
 * 
 * Design a class to find the kth largest element in a stream. Note that it is 
 * the kth largest element in the sorted order, not the kth distinct element.
 * 
 * Your KthLargest class will have a constructor which accepts an integer k 
 * and an integer array nums, which contains initial elements from the stream. 
 * For each call to the method KthLargest.add, return the element representing 
 * the kth largest element in the stream.
 * 
 * Example:
 * 
 * int k = 3;
 * int[] arr = [4,5,8,2];
 * KthLargest kthLargest = new KthLargest(3, arr);
 * kthLargest.add(3);   // returns 4
 * kthLargest.add(5);   // returns 5
 * kthLargest.add(10);  // returns 5
 * kthLargest.add(9);   // returns 8
 * kthLargest.add(4);   // returns 8
 * 
 * Note: You may assume that nums' length ≥ k-1 and k ≥ 1.
 */

namespace CSharpProblems
{
    public class Problem_703
    {
        public class KthLargest
        {
            public class TreeNode
            {
                public int val;
                public int count = 1;
                public TreeNode left;
                public TreeNode right;
                public TreeNode(int x) { val = x; }
            }

            TreeNode root;
            int kLargestElement;

            public KthLargest(int k, int[] nums)
            {
                kLargestElement = k;
                for (int i = 0; i < nums.Length; i++)
                {
                    root = AddNode(root, nums[i]);
                }
            }

            public int Add(int val)
            {
                root = AddNode(root, val);
                return FindKthLargest();
            }

            private TreeNode AddNode(TreeNode root, int val)
            {
                if (root == null)
                {
                    return new TreeNode(val);
                }

                root.count++;

                if (val < root.val)
                {
                    root.left = AddNode(root.left, val);
                }
                else
                {
                    root.right = AddNode(root.right, val);
                }

                return root;
            }

            private int FindKthLargest()
            {
                int count = kLargestElement;
                TreeNode curr = root;
                while (count > 0)
                {
                    int pos = 1 + (curr.right != null ? curr.right.count : 0);
                    if (count == pos) { break; }
                    if (count > pos)
                    {
                        count -= pos;
                        curr = curr.left;
                    }
                    else if (count < pos)
                    {
                        curr = curr.right;
                    }
                }
                return curr.val;
            }
        }

        /**
         * Your KthLargest object will be instantiated and called as such:
         * KthLargest obj = new KthLargest(k, nums);
         * int param_1 = obj.Add(val);
         */
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  : 
 * 		Space complexity : 
 */
