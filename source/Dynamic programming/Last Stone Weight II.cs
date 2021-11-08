public class Solution {
    public int LastStoneWeightII(int[] stones) {
        var dp = new int[1501];
        int sum = 0;
        for(int i = 0; i < stones.Length; i++)
            sum += stones[i];
        var target = sum / 2;
        
        for(int i = 0; i < stones.Length; i ++){
            for(int j = target; j >= stones[i]; j--){
                dp[j] = Math.Max(dp[j], dp[j - stones[i]] + stones[i]);
            }
        }
        var result = (sum - dp[target]) - dp[target];
        return result;
    }
}
