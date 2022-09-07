//Given an array of integers nums which is sorted in ascending order, and an integer target, 
//write a function to search target in nums. If target exists, then return its index. Otherwise, return -1
//--------------------------------------------------------------------------------------------------------

public class BinarySearchImplementation
{  
    public class BinarySearch
    {
        public BinarySearch() { }
        public int BinarySearchImplementation(int[] nums, int target){
            if(nums == null || nums.Length == 0){
                 return -1;
            }
            int left = 0, right = nums.Length - 1;

            while(left <= right){
                int mid = left + (right - left)/2;
                if(target == nums[mid]){
                    return mid;
                }
                else if(target > nums[mid]){
                    left = mid  + 1; //we need to search on the right side of mid, so adjust left position
                }
                else{ //we need to search on the left side of the mid, so adjust right position
                    right = mid - 1;
                }
            }
            return -1; //target does not exist.
        }

        public static void Main(string[] args)
        {
            int[] numbers = new int[]{-1,0,3,5,9,11,12,13,21,33,34,45};
            int target = 21;
            BinarySearch bs = new BinarySearch();
            int index = bs.BinarySearchImplementation(numbers, target);
            Console.WriteLine($"Index of the target number in numbers array : {index}");
            Console.WriteLine($"Number is: {numbers[index]}");
        }   
    }
}
