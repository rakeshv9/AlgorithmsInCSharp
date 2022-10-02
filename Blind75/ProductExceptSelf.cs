
// Given an integer array nums, return an array answer such that answer[i] is equal to the 
// product of all the elements of nums except nums[i].

// The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

// You must write an algorithm that runs in O(n) time and without using the division operation.

// Example 1:

// Input: nums = [1,2,3,4]
// Output: [24,12,8,6]



public class Blind75Questions
{  
      public int[] ProductExceptSelf(int[] nums) {
        int[] answer = new int[nums.Length];
        //nums = [1,2,3,4]
        //Build answer array by traversing from left to right [1, 1, 2, 6]
        for(int i=0, temp=1; i< nums.Length; i++){
            answer[i] = temp;
            temp = temp * nums[i];
        }
        //traverse from right to left and multiply answer array value with nums array values
        //to get the product
        //[1,1,2,6] ==> [1*24, 1*12, 2*4, 6*1]
        for(int j= nums.Length -1, temp = 1; j>=0; j--){
            answer[j] = temp * answer[j];
            temp = temp * nums[j];
        }
        return answer;
    }
    
    
    public static void Main(string[] args)
    {
      Blind75Questions obj = new Blind75Questions();
      int[] nums = {1,2,3,4};
      int[] productArrayExceptSelf = obj.ProductExceptSelf(nums);
      Console.WriteLine("Product of Array Except Self is");
      foreach(int n in productArrayExceptSelf){
        Console.WriteLine(n);
      }
    }
  }
