public class Solution {
    public int NumSquares(int n) {
        var nums = new int[101];
        for(int i = 1; i < nums.Length; i++){
            nums[i] = i * i;
        }
        var dp = new int[n+1];
        for(int i = 0; i <=n; i++){
            dp[i] = int.MaxValue;
        }
        dp[0] = 0;
        for(int i = 1; i <=n ; i++){
            for(int j = nums.Length - 1; j >=0; j--){
                if(i - nums[j] >=0 &&dp[i - nums[j]] != int.MaxValue)
                    dp[i] = Math.Min(dp[i], dp[i - nums[j]] + 1);
            }
        }
        return dp[n];
    }
}
