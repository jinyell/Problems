/*
 * Problem 155: Min Stack
 * Difficulty: Easy
 * 
 * Design a stack that supports push, pop, top, and retrieving the minimum 
 * element in constant time.
 * 
 *     push(x) -- Push element x onto stack.
 *     pop() -- Removes the element on top of the stack.
 *     top() -- Get the top element.
 *     getMin() -- Retrieve the minimum element in the stack.
 * 
 * Example:
 *      MinStack minStack = new MinStack();
 *      minStack.push(-2);
 *      minStack.push(0);
 *      minStack.push(-3);
 *      minStack.getMin();   --> Returns -3.
 *      minStack.pop();
 *      minStack.top();      --> Returns 0.
 *      minStack.getMin();   --> Returns -2.
 */

using System;

namespace CSharpProblems
{
    public class Problem_155
    {
        public class MinStack
        {

            private int[] data = new int[65536];
            private int[] min = new int[65536];
            int pos = -1;

            /** initialize your data structure here. */
            public MinStack()
            {
                min[0] = int.MaxValue;
            }

            public void Push(int x)
            {
                data[++pos] = x;
                min[pos + 1] = Math.Min(min[pos], x);
            }

            public void Pop()
            {
                pos--;
            }

            public int Top()
            {
                return data[pos];
            }

            public int GetMin()
            {
                return min[pos + 1];
            }
        }

        /**
         * Your MinStack object will be instantiated and called as such:
         * MinStack obj = new MinStack();
         * obj.Push(x);
         * obj.Pop();
         * int param_3 = obj.Top();
         * int param_4 = obj.GetMin();
         */
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity : 
 */
