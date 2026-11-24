public class Solution {
    public int MaxProfit(int[] prices) {
        var lowestPrice = prices[0];
        var maxProfit = 0;
        foreach (var price in prices)
        {
            if (price < lowestPrice)
            {
                lowestPrice = price;
                continue;
            }
            var profit = price - lowestPrice;
            if (profit > maxProfit)
            {
                maxProfit = profit;
            }
        }
        return maxProfit;
    }
}
