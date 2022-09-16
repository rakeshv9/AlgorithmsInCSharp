Priority Queue:
---------------
Priority Queue is an Abstract Data Structure (ADT), that is similar to Queue. Every element in Priority Queue has some priority value associated with it.

Properties of Priority Queue
  Every element has a priority associated with it.
  Element with higher priority is removed before an element with low priority
  If two elements have same priority, they are served according to their order in the queue.
  
  Priority Queue supports the following operations
    Insert or Enqueue -> O(logn) time complexity
    Find the Largest/Smallest or Peek -> O(1) time complexity
    Remove / Dequeue -> O(logn) time complexity
    
 You can use the following data structures to implement a priority queue. 
        Arrays
        Linked List
        Binary Search Tree
        Binary Heap
        
-----------------------------------------        
 Time complexity - Arrays
     Enqueue()     Dequeue()     Peek() |   O(1)         O(N)          O(N)
       
  Time complexity - Linked List
      Push()     Pop()     Peek()        |   O(N)      O(1)        O(1)
    
  Time complexity - Heap
     Insert()      Remove()     Peek()   |  O(logN)     O(logN)       O(1)
       
   Time complexity - Binary Search Tree
     Insert()      Remove()     Peek()   | O(logN)     O(logN)       O(1)
       
  Binary Heap is generally preferred for priority queue implementation because heaps provide better performance compared to arrays or LinkedList
