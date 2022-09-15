
//Input: numbers = [2,7,11,15], target = 9
//Output: [1,2]
//Explanation: The sum of 2 and 7 is 9. Therefore, index1 = 1, index2 = 2. We return [1, 2].

-----------------------------------------------------------------------------------------------



public class TwoSumInputArraySorted
{  
    public int[] TwoSum(int[] numbers, int target) {
        int start =0, end = numbers.Length - 1;

        while(start <= end){
            int sum = numbers[start] + numbers[end];
            //we found our indices, so return
            if(sum == target) return new int[]{start, end};
            //if the sum is greater than our target, move end pointer to left
            else if(sum > target){
                end = end - 1;
            }
            //we need to search on the right, so move start pointer to right
            else {
                start = start + 1;
            }
        }
        return new int[]{-1, -1};

    }

     public static void Main(string[] args)
    {
        int[] matrix = new int[]{2,7,11,15};
        TwoSumInputArraySorted bs = new TwoSumInputArraySorted();

        int[] indices = bs.TwoSum(matrix, 9);
        Console.WriteLine($"Indices of the two numbers from the given sorted array that add up to the target are: {string.Join(",", indices)}");
    }   
}
