public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length == 1)
            return nums[0];
        if(nums.Length == 2)
            return Math.Max(nums[0], nums[1]);
        return Math.Max(Rob(nums, 0, nums.Length - 2), Rob(nums, 1, nums.Length - 1));
    }
    
    public int Rob(int[] nums, int low, int high){
        if(low == high)
            return nums[low];
        var dp = new int[nums.Length];
        dp[low] = nums[low];
        dp[low + 1] = Math.Max(nums[low], nums[low + 1]);
        for(int i = low+2; i <= high; i++){
            dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i]);
        }
        return dp[high];
    }
}
