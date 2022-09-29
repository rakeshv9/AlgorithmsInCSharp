// Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] 
//such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
// Notice that the solution set must not contain duplicate triplets.

// Example 1:

// Input: nums = [-1,0,1,2,-1,-4]
// Output: [[-1,-1,2],[-1,0,1]]
// Explanation: 
// nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
// nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
// nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
// The distinct triplets are [-1,0,1] and [-1,-1,2].
// Notice that the order of the output and the order of the triplets does not matter.
------------------------------------------------------------------------------------
public class Blind75Questions
{  
    public IList<IList<int>> ThreeSum(int[] nums) {
       var result = new List<IList<int>>();
        if(nums == null || nums.Length == 0)
            return result;
        
        Array.Sort(nums);
        for(int i=0; i< nums.Length - 2; i++){
            if (i > 0 && nums[i] == nums[i - 1]) {  //Move i to skip same result
                 continue;
            }
            int j = i+ 1, k = nums.Length -1;
            while(j<k){
                int sum = nums[i] + nums[j] + nums[k];
                if(sum == 0){                     
                    result.Add(new List<int>(){nums[i], nums[j++], nums[k--]});
                    while (j < k && nums[j] == nums[j - 1]) j++;  // Move j to skip same result
                    while (j < k && nums[k] == nums[k + 1]) k--;  // Move k to skip same result
                }

                else if(sum > 0){
                    k--;
                }
                else {
                    j++;
                }
            }
        }
        return result;
    }
   
    public static void Main(string[] args)
    {
        int[] nums = new int[]{-1,0,1,2,-1,-4};
        Blind75Questions obj = new Blind75Questions();

        var triplets = obj.ThreeSum(nums);
        Console.WriteLine("Distinct triplets that add upto sum zero are: ");
        foreach(var x in triplets){
          Console.WriteLine(String.Join(",", x));
        }
    }   
}
