//Find the first occurence of the target number index in the given sorted duplicate array using Binary Search
//Time Complexity - O(logN)

//Sample input array = [4,5,6,6,7,7], target = 6 
//Output should be = 2. 
//Explanation: index 2 is where the value 6 first occred in the array.

---------------------------------------------------------------------------------------------------------------

public class FirstOccurenceInSortedDuplicateArray
{  
    public int FirstOccurence(int[] nums, int target) 
    {
        int left = 0, right = nums.Length-1;
        int index = -1;
        while(left <= right){
            int mid = left + (right - left)/2;
            //if target and mid index value are same, store the mid as index 
            //and keep searching on the left
            if(nums[mid] == target){
                index = mid;
                right =  mid - 1;
           }
           //if nums[mid] value is greater than target
           //adjust right to mid-1 to continue search on left side of mid
           else if(nums[mid] > target){
                right = mid - 1;
           }
           //keep searching on right side of mid
           else{ 
                left = mid + 1;
           }
        }
        return index; //if the number does not exist, return -1;
    }

     public static void Main(string[] args)
    {
        int[] sorted = new int[]{1,2,3,3,4,4,5,5,5,5,5,6,6};
        FirstOccurenceInSortedDuplicateArray bs = new FirstOccurenceInSortedDuplicateArray();

        int index = bs.FirstOccurence(sorted, 4);
        Console.WriteLine($"First occurence of number 4 is: {index}");
    }   
}
