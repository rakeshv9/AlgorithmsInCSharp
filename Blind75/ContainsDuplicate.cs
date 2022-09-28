//Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

//Example 1:

//Input: nums = [1,2,3,1]
//Output: true

//Time Complexity - O(N), Space Complexity - O(N)
----------------------------------------------------


public class Blind75Questions
{  
    public bool ContainsDuplicate(int[] nums) {
        List<int> set = new List<int>();
        foreach(int n in nums)
        {
            if (set.Contains(n))
            {
                return true;
            }
            set.Add(n);
        }
        return false;
    }
   
    public static void Main(string[] args)
    {
        int[] numbers = new int[]{1,2,3,4};
        Blind75Questions obj = new Blind75Questions();

        bool result = obj.ContainsDuplicate(numbers);
        Console.WriteLine("The given array contains duplicates:" +result);
    }   
}
