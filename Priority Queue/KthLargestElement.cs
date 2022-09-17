//Given an integer array nums and an integer k, return the kth largest element in the array.
//Note that it is the kth largest element in the sorted order, not the kth distinct element.
//You must solve it in O(n) time complexity.

//Example 1:

//Input: nums = [3,2,1,5,6,4], k = 2
//Output: 5

---------------------------------------------------------------------------------------------------

public class KthLargestElementInArray
{  
    public int KthLargest(int[] nums, int k) {
      //Priority Queue with Comparer for storing in Increasing Order
      PriorityQueue<int, int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((a,b)=>a-b));
      for(int i=0; i< nums.Length; i++){
        pq.Enqueue(nums[i], nums[i]);
        if(pq.Count > k){
          pq.Dequeue();
        }
    } 
       return pq.Peek();
  }
   
    public static void Main(string[] args)
    {
        int[] numbers = new int[]{3,2,1,5,6,4};
        KthLargestElementInArray obj = new KthLargestElementInArray();

        int value= obj.KthLargest(numbers, 2);
        Console.WriteLine($"Kth Largest Element in the Array is : {value}");
    }   
}
