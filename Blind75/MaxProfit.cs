// You are given an array prices where prices[i] is the price of a given stock on the ith day.
// You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
// Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

// Example 1:

// Input: prices = [7,1,5,3,6,4]
// Output: 5
// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.

public class Blind75Questions
{  
    public int MaxProfit(int[] prices) {
        int minPrice = Int32.MaxValue;
        int maxProfit = 0;
        for(int i=0; i< prices.Length; i++){
            if(prices[i] < minPrice ){
                minPrice = prices[i];
            }
            if(prices[i] - minPrice > maxProfit){
                maxProfit = prices[i] - minPrice;
            }
        }
        return maxProfit;
    }
   
    public static void Main(string[] args)
    {
        int[] prices = new int[]{7,1,5,3,6,4};
        Blind75Questions obj = new Blind75Questions();

        int maxProfit = obj.MaxProfit(prices);
        Console.WriteLine("Max Profit you can make buy selling stocks is: " +maxProfit);
    }   
}
