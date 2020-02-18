/*
 * Problem 706: Design HashMap
 * Difficulty: Easy
 * 
 * Design a HashMap without using any built-in hash table libraries.
 * 
 * To be specific, your design should include these functions:
 * 
 *     - put(key, value) : Insert a (key, value) pair into the HashMap. If the 
 * 						 value already exists in the HashMap, update the value.
 *     - get(key): Returns the value to which the specified key is mapped, or 
 * 				   -1 if this map contains no mapping for the key.
 *     - remove(key) : Remove the mapping for the value key if this map 
 * 					   contains the mapping for the key.
 * 
 * Example:
 * 
 * MyHashMap hashMap = new MyHashMap();
 * hashMap.put(1, 1);          
 * hashMap.put(2, 2);         
 * hashMap.get(1);            // returns 1
 * hashMap.get(3);            // returns -1 (not found)
 * hashMap.put(2, 1);          // update the existing value
 * hashMap.get(2);            // returns 1 
 * hashMap.remove(2);          // remove the mapping for 2
 * hashMap.get(2);            // returns -1 (not found) 
 * 
 * Note:
 *     All keys and values will be in the range of [0, 1000000].
 *     The number of operations will be in the range of [1, 10000].
 *     Please do not use the built-in HashMap library.
 */

namespace CSharpProblems
{
    public class Problem_706
    {
        public class MyHashMap
        {
            public class Buckets
            {
                public MyTuple[] myTuples;

                public Buckets()
                {
                    myTuples = new MyTuple[100];
                    for (int i = 0; i < 100; i++)
                    {
                        myTuples[i] = new MyTuple();
                    }
                }
            }
            public class MyTuple
            {
                public int key;
                public int val;

                public MyTuple()
                {
                    key = -1;
                    val = -1;
                }
            }

            private Buckets[] buckets;

            /** Initialize your data structure here. */
            public MyHashMap()
            {
                buckets = new Buckets[1000];

                for (int i = 0; i < 1000; i++)
                {
                    buckets[i] = new Buckets();
                }
            }

            /** value will always be non-negative. */
            public void Put(int key, int value)
            {
                int index = FindBucket(key);

                int keyIndex = FindKeyInBucket(key);
                if (keyIndex != -1)
                {
                    buckets[index].myTuples[keyIndex].val = value;
                    return;
                }

                for (int i = 0; i < 100; i++)
                {
                    if (buckets[index].myTuples[i].key == -1)
                    {
                        buckets[index].myTuples[i].key = key;
                        buckets[index].myTuples[i].val = value;
                        return;
                    }
                }
            }

            /** Returns the value to which the specified key is mapped, or -1 
				if this map contains no mapping for the key */
            public int Get(int key)
            {
                int index = FindBucket(key);
                for (int i = 0; i < 100; i++)
                {
                    if (buckets[index].myTuples[i].key == key)
                    {
                        return buckets[index].myTuples[i].val;
                    }
                }
                return -1;
            }

            /** Removes the mapping of the specified value key if this map 
				contains a mapping for the key */
            public void Remove(int key)
            {
                int index = FindBucket(key);
                for (int i = 0; i < 100; i++)
                {
                    if (buckets[index].myTuples[i].key == key)
                    {
                        buckets[index].myTuples[i].key = -1;
                        buckets[index].myTuples[i].val = -1;
                        return;
                    }
                }
            }

            private int FindKeyInBucket(int key)
            {
                int index = FindBucket(key);
                for (int i = 0; i < 100; i++)
                {
                    if (buckets[index].myTuples[i].key == key)
                    {
                        return i;
                    }
                }
                return -1;
            }

            private int FindBucket(int key)
            {
                return key % 1000;
            }
        }

        /**
         * Your MyHashMap object will be instantiated and called as such:
         * MyHashMap obj = new MyHashMap();
         * obj.Put(key,value);
         * int param_2 = obj.Get(key);
         * obj.Remove(key);
         */
    }
}

/*
 * Complexity Analysis
 * 		Time complexity  :
 * 		Space complexity : 
 */
