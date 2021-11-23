public class Solution {
    public int MaxProfit(int[] prices) {
        var dp = new int[prices.Length][];
        for(int i = 0; i < prices.Length; i++){
            dp[i] = new int[2];
        }
        // 第0天持有
        dp[0][0] -= prices[0];
        // 第0天不持有股票
        dp[0][1] = 0;
        
        
        for(int i = 1; i < prices.Length; i++){
            dp[i][0] = Math.Max(dp[i-1][0], 0 - prices[i]);
            dp[i][1] = Math.Max(dp[i-1][1], prices[i] + dp[i-1][0]);
            
        }
        return dp[prices.Length -1][1];
    }
}
