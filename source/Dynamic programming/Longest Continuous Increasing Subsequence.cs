public class Solution {
    public int FindLengthOfLCIS(int[] nums) {
        if(nums.Length <= 1)
            return nums.Length;
        int[] dp = new int[nums.Length];
        Array.Fill(dp,1);
        var max = 0;
        for(int i = 1; i < nums.Length;i++){
            if(nums[i] > nums[i-1])
                dp[i] = dp[i-1] + 1;
            
            if(dp[i] > max)
                max = dp[i];
        }
        return max;
    }
}
