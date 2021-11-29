public class Solution {
    public int LengthOfLIS(int[] nums) {
        if(nums.Length <= 1)
            return nums.Length;
        int[] dp = new int[nums.Length];
        Array.Fill(dp,1);
        var max = 0;
        for(int i = 1; i < nums.Length;i++){
            for(int j = 0; j < i; j++){
                if(nums[i] > nums[j])
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
            }
            if(dp[i] > max)
                max = dp[i];
        }
        return max;
    }
}
