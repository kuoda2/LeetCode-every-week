// Runtime: 80 ms, faster than 95.48% of C# online submissions for Coin Change 2.
// Memory Usage: 37.3 MB, less than 40.72% of C# online submissions for Coin Change 2.

public class Solution {
    public int Change(int amount, int[] coins) {
        var dp = new int[amount + 1];
        dp[0] = 1;
        for(int i = 0; i < coins.Length; i ++){
            for(int j = 0; j <= amount; j++){
                if(j >= coins[i])
                    dp[j] += dp[j - coins[i]];
            }
        }
        return dp[amount];
    }
}


// Runtime: 76 ms, faster than 99.09% of C# online submissions for Coin Change 2.
// Memory Usage: 37.1 MB, less than 47.96% of C# online submissions for Coin Change 2.

public class Solution2 {
    public int Change(int amount, int[] coins) {
        var dp = new int[amount + 1];
        dp[0] = 1;
        for(int i = 0; i < coins.Length; i ++){
            for(int j = coins[i]; j <= amount; j++){
                dp[j] += dp[j - coins[i]];
            }
        }
        return dp[amount];
    }
}
