// You are given an array of non-overlapping intervals intervals where intervals[i] = [starti, endi]
//  represent the start and the end of the ith interval and intervals is sorted in ascending order 
//  by starti. You are also given an interval newInterval = [start, end] that represents the start and 
//  end of another interval.

// Insert newInterval into intervals such that intervals is still sorted in ascending order by starti 
// and intervals still does not have any overlapping intervals (merge overlapping intervals if necessary).

// Return intervals after the insertion.

// Example 1:

// Input: intervals = [[1,3],[6,9]], newInterval = [2,5]
// Output: [[1,5],[6,9]]
// Example 2:

// Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
// Output: [[1,2],[3,10],[12,16]]
// Explanation: Because the new interval [4,8] overlaps with [3,5],[6,7],[8,10].


public class Blind75Problems
{  
    public int[][] InsertInterval(int[][] intervals, int[] newInterval) {    
        List<int[]> result = new List<int[]>();

        foreach(int[] interval in intervals){
          if(interval[0] > newInterval[1])
            {
                result.Add(newInterval);
                newInterval = interval;
            }  
            else if(interval[1] < newInterval[0])
            {
                result.Add(interval);
            } 
            else {
                newInterval[0] = Math.Min(newInterval[0],interval[0]);
                newInterval[1] = Math.Max(newInterval[1],interval[1]);
            }
        }
        
        result.Add(newInterval);

        return result.ToArray();
    }

    public static void Main(string[] args)
    {
      Blind75Problems obj = new Blind75Problems();
      int[][] arr = new int[][]{new int[]{1, 3}, new int[]{6,9}};
      int[] targetInterval = new int[]{2,5};
      int[][] updatedInterval = obj.InsertInterval(arr, targetInterval);
      Console.WriteLine("Smallest Letter Greater Than Target:");
      foreach(int[] interval in updatedInterval){
        Console.WriteLine(interval[0] +"," +interval[1]);
      }
    }
  }
