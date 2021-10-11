public class Solution {
    public int MaxProfit(int[] prices, int fee) {
        if(prices.Length < 2) return 0;
        var result = 0;
        var min = prices[0];
        for(int i = 1; i < prices.Length; i++)
        {
            if(prices[i] < min)
            {
                min = prices[i];
            }
            else if(prices[i] > min + fee)
            {
                result += prices[i] - min - fee;
                min = prices[i] - fee;
            }
        }
        return result;
    }
}
