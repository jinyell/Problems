/*
 * Problem 232: Implement Queue using Stacks
 * Difficulty: Easy
 * 
 * Implement the following operations of a queue using stacks.
 * 
 *     push(x) -- Push element x to the back of queue.
 *     pop() -- Removes the element from in front of queue.
 *     peek() -- Get the front element.
 *     empty() -- Return whether the queue is empty.
 * 
 * Example:
 *      MyQueue queue = new MyQueue();
 * 
 *      queue.push(1);
 *      queue.push(2);  
 *      queue.peek();  // returns 1
 *      queue.pop();   // returns 1
 *      queue.empty(); // returns false
 * 
 * Notes:
 *     - You must use only standard operations of a stack -- which means 
 * 		 only push to top, peek/pop from top, size, and is empty operations 
 * 		 are valid.
 *     - Depending on your language, stack may not be supported natively. 
 * 		 You may simulate a stack by using a list or deque (double-ended 
 * 		 queue), as long as you use only standard operations of a stack.
 *     - You may assume that all operations are valid (for example, no pop 
 * 		 or peek operations will be called on an empty queue).
 */

using System.Collections.Generic;

namespace CSharpProblems
{
    public class Problem_232
    {
        public class MyQueue
        {
            private Stack<int> stack1;
            private Stack<int> stack2;

            /** Initialize your data structure here. */
            public MyQueue()
            {
                stack1 = new Stack<int>();
                stack2 = new Stack<int>();
            }

            /** Push element x to the back of queue. */
            public void Push(int x)
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
                stack1.Push(x);
                while (stack2.Count > 0)
                {
                    stack1.Push(stack2.Pop());
                }
            }

            /* Removes the element in front of queue & returns that element. */
            public int Pop()
            {
                return stack1.Pop();
            }

            /** Get the front element. */
            public int Peek()
            {
                return stack1.Peek();
            }

            /** Returns whether the queue is empty. */
            public bool Empty()
            {
                return stack1.Count == 0;
            }
        }

        /**
         * Your MyQueue object will be instantiated and called as such:
         * MyQueue obj = new MyQueue();
         * obj.Push(x);
         * int param_2 = obj.Pop();
         * int param_3 = obj.Peek();
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
