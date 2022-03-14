public class Solution {
    public int Rob(int[] nums)
    {
        if(nums.Length == 0)
            return 0;
        // 迭代的時候需要考慮兩層，避免out of rage
        var dp = new int[nums.Length + 1];
        dp[1] = nums[0];
        for(int i = 2; i <= nums.Length; i++){
            dp[i] = Math.Max(dp[i-1], dp[i - 2] + nums[i-1]);
        }
        return dp[nums.Length];
    }
    public int Rob2(int[] nums)
    {
        if(nums.Length == 0)
            return 0;
        if(nums.Length == 1)
            return nums[0];
        var dp = new int[nums.Length];
        dp[0] = nums[0];
        dp[1] = Math.Max(nums[0], nums[1]);
        for(int i = 2; i < nums.Length; i++){
            dp[i] = Math.Max(dp[i-1], dp[i-2] + nums[i]);
        }
        return dp[nums.Length-1];
    }
}
