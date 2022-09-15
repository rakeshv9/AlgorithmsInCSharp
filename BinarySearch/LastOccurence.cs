//Find the last occurence of the target number index in the given sorted duplicate array using Binary Search
//Time Complexity - O(logN)

//Sample input array = [4,5,6,6,7,7], target = 6 
//Output should be = 3. 
//Explanation: index 3 is where the value 6 last occred in the array.

---------------------------------------------------------------------------------------------------------------


public class LastOccurenceInSortedDuplicateArray
{  
    public int LastOccurence(int[] nums, int target) 
    {
        int left = 0, right = nums.Length-1;
        int index = -1;
        while(left <= right)
        {
            int mid = left + (right - left)/2;
            //if target and mid index value are same, store the mid as index 
            //and keep searching on the right
            if(nums[mid] == target){
                index = mid;
                left =  mid + 1;
           }
           //if target is greater than nums[mid] value 
           //adjust left to mid+1 to continue search on right side of mid
           else if(target > nums[mid]){
                left = mid + 1;
           }
           //adjust right to mid-1
           else{ 
                right = mid - 1;
           }
        }
        return index; //if the number does not exist, return -1;
    }

     public static void Main(string[] args)
    {
        int[] sorted = new int[]{4,5,6,6,7,7};
        LastOccurenceInSortedDuplicateArray bs = new LastOccurenceInSortedDuplicateArray();

        int index = bs.LastOccurence(sorted, 6);
        Console.WriteLine($"Last occurence of number 6 is: {index}");
    }   
}
