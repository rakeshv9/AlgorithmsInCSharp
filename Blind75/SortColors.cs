
// Given an array nums with n objects colored red, white, or blue, sort them in-place 
// so that objects of the same color are adjacent, with the colors in the order red, white, and blue.
// We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.
// You must solve this problem without using the library's sort function.

// Example 1:

// Input: nums = [2,0,2,1,1,0]
// Output: [0,0,1,1,2,2]



public class Blind75Questions
{  
      public void SortColors(int[] nums) {
        int low =0, medium = 0, high = nums.Length - 1;
        while(medium <= high){
            if(nums[medium] == 0){ //push it to left
                int temp = nums[low];
                nums[low] = nums[medium];
                nums[medium] = temp;
                low++;
                medium++;
            }
            else if(nums[medium] == 1){ //keep moving medium pointer
                medium++;
            }
            else{
                int temp = nums[high]; //push it to right
                nums[high] = nums[medium];
                nums[medium] = temp;
                high--; 
            }
        }
    }

    public static void Main(string[] args)
    {
      Blind75Questions obj = new Blind75Questions();
      int[] nums = {1,0,2,1,1,0};

      obj.SortColors(nums);
      Console.WriteLine("Sorted Colors:");
      foreach(int n in nums){
        Console.WriteLine($"\n{n}");
      }
    }
  }
