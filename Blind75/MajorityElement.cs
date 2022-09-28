// Given an array nums of size n, return the majority element.
// The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

// Example 1:
// Input: nums = [3,2,3]
// Output: 3
// Example 2:

// Input: nums = [2,2,1,1,1,2,2]
// Output: 2
----------------------------------------------------------------------------------

public class Blind75Questions
{  
      public int MajorityElement(int[] nums) {
      int len = nums.Length;
       Dictionary<int, int> dict = new Dictionary<int, int>();
       for(int i=0; i< len; i++){
           if(dict.ContainsKey(nums[i])){
               dict[nums[i]] = dict[nums[i]] + 1;
           }
           else{
               dict.Add(nums[i], 1);
           }
       }
        
      for(int i=0; i< len; i++){
          //if you find any key that returns an elements that appears more than n/2 times, you can simply return the key.
          if(dict[nums[i]] > len/2){
              return nums[i];
          }
      }
        return -1;
    }
   
    public static void Main(string[] args)
    {
        int[] numbers = new int[]{1,2,3,4};
        Blind75Questions obj = new Blind75Questions();

        int result = obj.MajorityElement(numbers);
        Console.WriteLine("The Majority Element in the given array is" +result);
    }   
}
