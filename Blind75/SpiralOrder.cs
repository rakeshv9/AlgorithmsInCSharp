
// Given an m x n matrix, return all elements of the matrix in spiral order.
// Example 1:

// Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
// Output: [1,2,3,6,9,8,7,4,5]



public class Blind75Questions
{  
    public List<int> SpiralOrder(int[,] matrix) {
       var result = new List<int>();
       int startRow = 0, startCol = 0, endRow = matrix.GetLength(0) -1, endCol = matrix.GetLength(1) - 1;
       string direction ="ToRight";
       while(startRow <= endRow && startCol <= endCol){
           if(direction == "ToRight"){
               for(int i = startCol; i<= endCol; i++){
                   result.Add(matrix[startRow, i]);
               }
               ++startRow;
               direction = "ToDown";
           }
           else if(direction == "ToDown"){
               for(int i= startRow; i<= endRow; i++){
                   result.Add(matrix[i, endCol]);
               }
               --endCol;
               direction ="ToLeft";
           }
           else if(direction == "ToLeft"){
               for(int i= endCol; i>= startCol; i--){
                   result.Add(matrix[endRow, i]);
               }
               --endRow;
               direction = "ToUp";
           }
           else if(direction == "ToUp"){
               for(int i=endRow; i>= startRow; i--){
                   result.Add(matrix[i, startCol]);
               }
               ++startCol;
               direction = "ToRight";
           }
       }
       return result; 
    }

    public static void Main(string[] args)
    {
      Blind75Questions obj = new Blind75Questions();
      int[,] nums = new int[3,3] {{1,2,3},{4,5,6},{7,8,9}};
      //[1, 2, 3]
      //[4, 5, 6] ===> Spiral Order would be [1,2,3,6,9,8,7,4,5]
      //[7, 8, 9]

      List<int> spriralOrder = obj.SpiralOrder(nums);
      Console.WriteLine("Sprial order of the given 3*3 matrix is");
      foreach(int n in spriralOrder){
        Console.WriteLine(n);
      }
    }
  }
