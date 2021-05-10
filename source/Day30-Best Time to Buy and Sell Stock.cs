public class Solution {
    public int MaxProfit(int[] prices) {
        int min = prices[0];
        int profit = 0;
        int result = 0;
        for(int i = 1; i < prices.Length; i++){
            profit = Math.Max(profit, prices[i] - min);
            if((prices[i] - min) == profit)
                result = i + 1;
            min = Math.Min(min, prices[i]);

        }
        return profit;
    }
}
