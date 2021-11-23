public class Solution {
    public int MaxProfit(int k, int[] prices) {
        if(prices.Length == 0) return 0;
        var dp = new int[prices.Length][];
        for(int i = 0; i < prices.Length; i++){
            dp[i] = new int[2*k+1];
        }
        
        for(int i = 1; i <= 2 * k; i += 2){
                dp[0][i] -= prices[0];
        }
        
        for(int i = 1; i < prices.Length; i++){
            dp[i][0] = dp[i-1][0];
            for(int j = 1; j <= 2 * k; j++){
                var price = prices[i] * (j % 2 == 0 ? 1 : -1);
                dp[i][j] = Math.Max(dp[i-1][j], dp[i-1][j-1] + price);
            }
        }
        return dp[prices.Length -1][2*k];
    }
}
