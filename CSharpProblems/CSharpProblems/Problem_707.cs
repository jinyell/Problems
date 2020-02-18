/*
 * Problem 707: Design Linked List
 * Difficulty: Easy
 * 
 * Design your implementation of the linked list. You can choose to use the 
 * singly linked list or the doubly linked list. A node in a singly linked 
 * list should have two attributes: val and next. val is the value of the 
 * current node, and next is a pointer/reference to the next node. If you 
 * want to use the doubly linked list, you will need one more attribute prev 
 * to indicate the previous node in the linked list. Assume all nodes in the 
 * linked list are 0-indexed.
 * 
 * Implement these functions in your linked list class:
 * 
 *     get(index) : Get the value of the index-th node in the linked list. 
 * 					If the index is invalid, return -1.
 *     addAtHead(val) : Add a node of value val before the first element of 
 * 						the linked list. After the insertion, the new node 
 * 						will be the first node of the linked list.
 *     addAtTail(val) : Append a node of value val to the last element of 
 * 						the linked list.
 *     addAtIndex(index, val) : Add a node of value val before the 
 * 					index-th node in the linked list. If index equals to the 
 * 					length of linked list, the node will be appended to the 
 * 					end of linked list. If index is greater than the length, 
 * 					the node will not be inserted. If index is negative, the 
 * 					node will be inserted at the head of the list.
 *     deleteAtIndex(index) : Delete the index-th node in the linked list, 
 * 							  if the index is valid.
 * 
 * Example:
 * 
 * MyLinkedList linkedList = new MyLinkedList();
 * linkedList.addAtHead(1);
 * linkedList.addAtTail(3);
 * linkedList.addAtIndex(1, 2);  // linked list becomes 1->2->3
 * linkedList.get(1);            // returns 2
 * linkedList.deleteAtIndex(1);  // now the linked list is 1->3
 * linkedList.get(1);            // returns 3
 * 
 * Note:
 *     All values will be in the range of [1, 1000].
 *     The number of operations will be in the range of [1, 1000].
 *     Please do not use the built-in LinkedList library.
 */

namespace CSharpProblems
{
    public class Problem_707
    {
        // Doubly Linked LIst
        public class MyLinkedList
        {
            public class Node
            {
                public int val;
                public Node prev;
                public Node next;
                public Node(int x) { val = x; }
            }

            private Node head;
            private Node tail;
            private int count;

            /** Initialize your data structure here. */
            public MyLinkedList()
            {
                head = null;
                tail = null;
                count = 0;
            }

            /** Get the value of the index-th node in the linked list. If 
				the index is invalid, return -1. */
            public int Get(int index)
            {
                if (index < 0 || index >= count)
                {
                    return -1;
                }

                Node current = head;
                int iterator = 0;
                while (current != null)
                {
                    if (index == iterator)
                    {
                        return current.val;
                    }
                    current = current.next;
                    iterator++;
                }
                return -1;
            }

            /** Add a node of value val before the first element of the 
				linked list. After the insertion, the new node will be the 
				first node of the linked list. */
            public void AddAtHead(int val)
            {
                Node addNode = new Node(val);

                if (head == null)
                {
                    head = addNode;
                    tail = addNode;
                }
                else
                {
                    addNode.next = head;
                    head.prev = addNode;
                    head = addNode;
                }
                count++;
            }

            /** Append a node of value val to the last element of the 
				linked list. */
            public void AddAtTail(int val)
            {
                Node addNode = new Node(val);

                if (head == null)
                {
                    head = addNode;
                    tail = addNode;
                }
                else
                {
                    tail.next = addNode;
                    addNode.prev = tail;
                    tail = addNode;
                }
                count++;
            }

            /** Add a node of value val before the index-th node in the 
				linked list. If index equals to the length of linked list, 
				the node will be appended to the end of linked list. If index 
				is greater than the length, the node will not be inserted. */
            public void AddAtIndex(int index, int val)
            {
                if (index < 0 || index > count)
                {
                    return;
                }

                if (index == 0)
                {
                    AddAtHead(val);
                    return;
                }

                if (index == count)
                {
                    AddAtTail(val);
                    return;
                }

                Node current = head;
                int iterator = 0;
                while (current != null)
                {
                    if (index == iterator)
                    {
                        Node addNode = new Node(val);
                        addNode.prev = current.prev;
                        addNode.next = current;
                        current.prev.next = addNode;
                        current.prev = addNode;
                        count++;
                        return;
                    }
                    current = current.next;
                    iterator++;
                }
            }

            /** Delete the index-th node in the linked list, if the index 
				is valid. */
            public void DeleteAtIndex(int index)
            {
                if (index < 0 || index >= count)
                {
                    return;
                }

                Node current = head;
                int iterator = 0;
                while (current != null)
                {
                    if (iterator == index)
                    {
                        count--;
                        if (current.prev == null)
                        {
                            head = head.next;
                            if (count == 0)
                            {
                                tail = null;
                            }
                            else
                            {
                                head.prev = null;
                            }
                            return;

                        }
                        else
                        {
                            current.prev.next = current.next;

                            if (current.next == null)
                            {
                                tail = current.prev;
                            }
                            else
                            {
                                current.next.prev = current.prev;
                            }
                            return;
                        }
                    }
                    current = current.next;
                    iterator++;
                }
            }

            private bool IsEmpty()
            {
                return head == null;
            }
        }
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity : 
 */
