public class Solution {
    public int MaxProfit(int[] prices) {
        var dp = Enumerable.Range(0, prices.Length)
                    .Select(x => Enumerable.Repeat(0, 4).ToArray()).ToArray();
        dp[0][0] = 0 - prices[0];
        
        for(int i = 1 ; i < prices.Length; i++){
            // 持有 = 前一天持有 or 前一天空手 or 前一天cooldown
            dp[i][0] = Math.Max(dp[i-1][0], Math.Max(dp[i-1][1], dp[i-1][3]) - prices[i]);
            // 空手 = 前一天空手 or 前一天cooldown
            dp[i][1] = Math.Max(dp[i-1][1], dp[i-1][3]);
            // i day 賣出 = 前一天持有 + 賣出的金額
            dp[i][2] = dp[i-1][0] + prices[i];
            // i day cooldown = 前一天賣出
            dp[i][3] = dp[i-1][2];
        }
        return Math.Max(dp[^1][1], Math.Max(dp[^1][2], dp[^1][3]));
        
    }
}
