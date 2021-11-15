public class Solution {
    public int CoinChange(int[] coins, int amount) {
        var dp = new int[amount+1];
        for(int i = 1; i < dp.Length; i ++){
            dp[i] = int.MaxValue;
        }
        dp[0] = 0;
        
        for(int i = 1; i <= amount; i++){
            for(int j = 0; j < coins.Length; j++){
                if(i - coins[j] >= 0 && dp[i-coins[j]] != int.MaxValue)
                    dp[i] = Math.Min(dp[i], dp[i-coins[j]] + 1);
            }
        }
        return dp[amount] == int.MaxValue ? -1 : dp[amount];
    }
}
