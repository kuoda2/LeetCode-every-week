public class Solution {
    public int UniquePaths(int m, int n) {
        var dp = new int[m][];
        for (int i = 0; i < dp.Length; i++)
        {
            dp[i] = new int[n];
            dp[i][0] = 1;
        }
        
        for(int i = 0; i < dp[0].Length; i++){
            dp[0][i] = 1;
        }
        
        for(int i = 1 ; i < dp[0].Length; i++){
            for(int j = 1; j <  dp.Length; j++){
                dp[j][i] = dp[j-1][i] + dp[j][i-1];
            }
        }
        return dp[m-1][n-1];
        
    }
}
