//Given an array nums containing n distinct numbers in the range [0, n], 
//return the only number in the range that is missing from the array.
-------------------------------------------------------------------------

public class MissingNumber
{  
    public class FindMissingNumber
    {
        public FindMissingNumber() { }
        //Array is sorted - Perform binary search. Time Complexity - O(logn)
        public int MissingNumberSortedArray(int[] nums){
            int left = 0, right = nums.Length - 1;

            while(left <= right){
                int mid = left + (right - left)/2;
                if(nums[mid] > mid){
                    right = mid -1;
                }
                else{
                    left = mid + 1;
                }
            }
            return left;
        }

        //Array is not sorted - Use the Math condition. Time Complexity - O(N)
        public int FindMissingNumberUnSortedArray(int[] nums){
            int n = nums.Length;
            int totalSum = (n * (n+1))/2;
            int actualSum = 0;
            
            for(int i=0; i< n; i++){
                actualSum = actualSum + nums[i];
            }
            return totalSum - actualSum;
        }

        public static void Main(string[] args)
        {
            int[] sorted = new int[]{0,1,2,3,4,5,7};
            FindMissingNumber bs = new FindMissingNumber();
            int num = bs.MissingNumberSortedArray(sorted);
            Console.WriteLine($"Missing number in the given sorted array is: {num}");

            int[] unsorted = new int[] {2,0,1,6,4,7,5};
            int num2 = bs.FindMissingNumberUnSortedArray(unsorted);
            Console.WriteLine($"Missing number in the given unsorted array is: {num2}");
        }   
    }
}
