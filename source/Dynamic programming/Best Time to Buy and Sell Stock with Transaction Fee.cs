public class Solution {
    public int MaxProfit(int[] prices, int fee) {
        var dp = Enumerable.Range(0, prices.Length)
                    .Select(x => Enumerable.Repeat(0, 2).ToArray()).ToArray();
        dp[0][0] = 0 - prices[0];
        
        for(int i = 1 ; i < prices.Length; i++){
            // 持有 = 前一天持有 or 前一天空手並買入
            dp[i][0] = Math.Max(dp[i-1][0], (dp[i-1][1] - prices[i]));
            // 空手 = 前一天空手 or 前一天持有並賣出
            dp[i][1] = Math.Max(dp[i-1][1], dp[i-1][0] + prices[i] - fee);
        }
        return Math.Max(dp[^1][0], dp[^1][1]);
    }
}
