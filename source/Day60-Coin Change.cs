public class Solution {
    public int CoinChange(int[] coins, int amount) {
      if (amount < 1) return 0;
            int[] dp = new int[amount + 1];
            Array.Fill(dp, int.MaxValue);
            dp[0] = 0;
            for (int i = 0; i < coins.Length; i++)
            {
                var coin = coins[i];
                for (int j = coin; j <= amount; j++)
                {
                    if (dp[j - coin] != int.MaxValue)
                    {
                        dp[j] = Math.Min(dp[j], dp[j - coin] + 1);
                    }
                }
            }
            return dp[amount] == int.MaxValue ? -1 : dp[amount];
    }
}
