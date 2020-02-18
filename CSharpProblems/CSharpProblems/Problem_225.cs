/*
 * Problem 225: Implement Stack using Queues
 * Difficulty: Easy
 * 
 * Implement the following operations of a stack using queues.
 * 
 *     push(x) -- Push element x onto stack.
 *     pop() -- Removes the element on top of the stack.
 *     top() -- Get the top element.
 *     empty() -- Return whether the stack is empty.
 * 
 * Example:
 *      MyStack stack = new MyStack();
 * 
 *      stack.push(1);
 *      stack.push(2);  
 *      stack.top();   // returns 2
 *      stack.pop();   // returns 2
 *      stack.empty(); // returns false
 * 
 * Notes:
 *     - You must use only standard operations of a queue -- which means only 
 * 		 push to back, peek/pop from front, size, and is empty operations 
 * 		 are valid.
 *     - Depending on your language, queue may not be supported natively. 
 * 		 You may simulate a queue by using a list or deque (double-ended 
 * 		 queue), as long as you use only standard operations of a queue.
 *     - You may assume that all operations are valid (for example, no pop 
 * 	     or top operations will be called on an empty stack).
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_225
    {
        public class MyStack
        {
            private Queue<int> queueStack;

            /** Initialize your data structure here. */
            public MyStack()
            {
                queueStack = new Queue<int>();
            }

            /** Push element x onto stack. */
            public void Push(int x)
            {
                queueStack.Enqueue(x);

                for (int i = 0; i < queueStack.Count - 1; i++)
                {
                    queueStack.Enqueue(queueStack.Dequeue());
                }
            }

            /* Removes the element on top of the stack & returns that element*/
            public int Pop()
            {
                return queueStack.Dequeue();
            }

            /** Get the top element. */
            public int Top()
            {
                return queueStack.Peek();
            }

            /** Returns whether the stack is empty. */
            public bool Empty()
            {
                return queueStack.Count == 0;
            }
        }

        /**
         * Your MyStack object will be instantiated and called as such:
         * MyStack obj = new MyStack();
         * obj.Push(x);
         * int param_2 = obj.Pop();
         * int param_3 = obj.Top();
         * bool param_4 = obj.Empty();
         */
    }
}

/*
 * Complexity Analysis:
 * 
 * 		Time complexity : 
 * 		Space complexity: 
 */
