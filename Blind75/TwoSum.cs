//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
//You may assume that each input would have exactly one solution, and you may not use the same element twice.
//You can return the answer in any order.

//Example 1:

//Input: nums = [2,7,11,15], target = 9
//Output: [0,1]
//Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
----------------------------------------------------------------------------

public class Blind75Questions
{  
    public int[] TwoSum(int[] nums, int target) 
    {
      if(nums == null || nums.Length == 0){
        return new int[]{-1, -1};
      }
      Dictionary<int, int> map = new Dictionary<int, int>();
      for(int i=0; i< nums.Length; i++){
        int numToFind = target - nums[i];
        if(map.ContainsKey(numToFind)){
          return new int[]{map[numToFind], i};
        }else{
          map.Add(nums[i], i);
        }
      }
        return new int[]{-1, -1};
    }
   
    public static void Main(string[] args)
    {
        int[] numbers = new int[]{3,2,4,5,9,7};
        Blind75Questions obj = new Blind75Questions();

        int[] indices = obj.TwoSum(numbers, 11);
        Console.WriteLine("Indices of the two numbers that add up to given target are:");
        foreach(int n in indices){
            Console.WriteLine(n);
        }
    }   
}
