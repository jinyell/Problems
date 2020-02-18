﻿/*
 * Problem 705: Design HashSet
 * Difficulty: Easy
 * 
 * Design a HashSet without using any built-in hash table libraries.
 * 
 * To be specific, your design should include these functions:
 * 
 *    - add(value): Insert a value into the HashSet. 
 *    - contains(value) : Return whether the value exists in the HashSet or not.
 *    - remove(value): Remove a value in the HashSet. If the value does not 
 * 		exist in the HashSet, do nothing.
 * 
 * Example:
 * 
 * MyHashSet hashSet = new MyHashSet();
 * hashSet.add(1);         
 * hashSet.add(2);         
 * hashSet.contains(1);    // returns true
 * hashSet.contains(3);    // returns false (not found)
 * hashSet.add(2);          
 * hashSet.contains(2);    // returns true
 * hashSet.remove(2);          
 * hashSet.contains(2);    // returns false (already removed)
 * 
 * Note:
 *     All values will be in the range of [0, 1000000].
 *     The number of operations will be in the range of [1, 10000].
 *     Please do not use the built-in HashSet library.
 */

namespace CSharpProblems
{
    public class Problem_705
    {
        public class MyHashSet
        {
            bool[] hashSet;

            /** Initialize your data structure here. */
            public MyHashSet()
            {
                hashSet = new bool[1000001];
            }

            public void Add(int key)
            {
                hashSet[key] = true;
            }

            public void Remove(int key)
            {
                hashSet[key] = false;
            }

            /** Returns true if this set contains the specified element */
            public bool Contains(int key)
            {
                return hashSet[key];
            }
        }

        /**
         * Your MyHashSet object will be instantiated and called as such:
         * MyHashSet obj = new MyHashSet();
         * obj.Add(key);
         * obj.Remove(key);
         * bool param_3 = obj.Contains(key);
         */
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity : 
 */
