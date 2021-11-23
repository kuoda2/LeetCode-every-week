public class Solution {
    public int MaxProfit(int[] prices) {
        var dp = new int[prices.Length][];
        for(int i = 0; i < prices.Length; i++){
            dp[i] = new int[5];
        }
        // 第0天沒有動作
        dp[0][0] = 0;
        // 第0天第一次持有股票
        dp[0][1] -= prices[0];
        // 第0天第一次沒持有股票
        dp[0][2] = 0;
        dp[0][3] = int.MinValue;
        
        for(int i = 1; i < prices.Length; i++){
            dp[i][0] = dp[i-1][0];
            dp[i][1] = Math.Max(dp[i-1][1], dp[i-1][0] - prices[i]);
            dp[i][2] = Math.Max(dp[i-1][2], dp[i-1][1] + prices[i]);
            dp[i][3] = Math.Max(dp[i-1][3], dp[i-1][2] - prices[i]);
            dp[i][4] = Math.Max(dp[i-1][4], dp[i-1][3] + prices[i]);
        }
        return dp[prices.Length -1][4];
    }
}
