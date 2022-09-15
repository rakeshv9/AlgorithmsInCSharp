//Write an efficient algorithm that searches for a value target in an m x n integer matrix matrix. 
//This matrix has the following properties:
  //Integers in each row are sorted from left to right.
  //The first integer of each row is greater than the last integer of the previous row.
 
//Example 1:

//Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 3
//Output: true
----------------------------------------------------------------------------------------------------

public class Search2DMatrix
{  
    public bool searchMatrix(int[,] matrix, int target) {
    int start = 0, m = matrix.GetLength(0), n = matrix.GetLength(1), end = m * n - 1;
    while(start <= end){
        int mid = (start + end)/2;
        //if you re-write 2D matrix in a 1D array, the index of last element is = m*n-1;
        //To calculate mid in a 2D matrix, you can use mid/n = row, mid % n = column
        int mid_point = matrix[mid / n, mid % n];
        if(target == mid_point) return true;
        if(mid_point < target)
            start = mid + 1;
        else 
            end = mid - 1;
     }
     return false;
    }

     public static void Main(string[] args)
    {
        int[,] matrix = new int[3,4]{{1,3,5,7},{10,11,16,20},{23,30,34,60}};
        Search2DMatrix bs = new Search2DMatrix();

        bool index = bs.searchMatrix(matrix, 20);
        Console.WriteLine($"20 exists in given matrix: {index}");
    }   
}
