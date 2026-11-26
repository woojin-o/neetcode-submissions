public class Solution {
    public int MaxProfit(int[] prices) {
       var lowest = prices[0];
       var max = 0;
       foreach (var price in prices)
       {
            if (price < lowest)
            {
                lowest = price;
                continue;
            }
            var profit = price - lowest;
            if (profit > max)
            {
                max = profit;
            }
       } 

       return max;
    }
}
