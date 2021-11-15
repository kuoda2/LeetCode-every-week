public class Solution {
    public int ClimbStairs(int n) {
        if(n <= 2)
            return n;
        int[] dp = new int[n+1];
        dp[1] = 1;
        dp[2] = 2;
        
        for(int i = 3; i <= n; i++){
            dp[i] = dp[i -1] + dp[i - 2];
        }
        return dp[n];
    }
}

public class Solution2 {
    public int ClimbStairs(int n) {
        int[] dp = new int[n+1];
        dp[0] = 1;
        var maxStep = 2;
        
        for(int i = 1; i <= n; i++){
            for(int j = 1; j <= maxStep; j++){
                if(i - j >= 0)
                    dp[i] += dp[i-j];
            }
        }
        return dp[n];
    }
}
