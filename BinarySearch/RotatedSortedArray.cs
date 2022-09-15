
//LeetCode 33. Search in Rotated Sorted Array

//There is an integer array nums sorted in ascending order (with distinct values).
//Prior to being passed to your function, nums is possibly rotated at an unknown pivot index k (1 <= k < nums.length) 
//such that the resulting array is [nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]] (0-indexed). 
//For example, [0,1,2,4,5,6,7] might be rotated at pivot index 3 and become [4,5,6,7,0,1,2].
//Given the array nums after the possible rotation and an integer target, return the index of target if it is in nums, or -1 if it is not in nums.
------------------------------------------------------------------------------------------------------------------------------------------------

public class RotatedSortedArray
{  
    public int search(int[] nums, int target) 
    {
        int left = 0, right = nums.Length-1;
        
        while(left <= right){
            int mid = (left + right)/2;
            if(nums[mid] == target)
                return mid;
            
            //check if the left part and mid values of the array are in ascending order (sorted order)
            if(nums[left] <= nums[mid]){
                //if the above condition is true, then compare the target with left and mid index values
                //and move left and right pointers accordingly
                if(target >= nums[left] && target < nums[mid]){
                    right = mid - 1;
                }
                else{
                    left = mid + 1;
                }
            }
            //check if the mid and right values of the array are in ascending order (sorted order)
            else if(nums[mid] <= nums[right]){
                //if the above condition is true, then compare the target with mid and mid index values
                //and move left and right pointers accordingly
                if(target > nums[mid] && target <= nums[right]){
                    left = mid + 1;
                }
                else{
                    right = mid - 1;
                }
            }
        }
            return -1; //if the number does not exist, return -1;
    }

     public static void Main(string[] args)
    {
        int[] sorted = new int[]{4,5,6,7,8,9,0,1,2,3};
        RotatedSortedArray bs = new RotatedSortedArray();

        int index = bs.search(sorted, 2);
        Console.WriteLine($"Index of number 2 is: {index}");
    }   
}
