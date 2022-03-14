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
    public int Rob2(int[] nums) {
        if(nums.Length == 1)
            return nums[0];
        
        if(nums.Length == 2)
            return Math.Max(nums[0], nums[1]);
        var result = Math.Max(Rob(nums, 0, nums.Length - 2), Rob(nums, 1, nums.Length - 1));
        return result;
        
    }
    
    private int Rob2(int[] nums, int left, int right){
        if(left == right)
            return nums[left];
        
        var dp = new int[nums.Length];
        dp[left] = nums[left];
        dp[left + 1] = Math.Max(nums[left], nums[left + 1]);
        
        for(int i = left + 2; i <= right; i++){
            dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i]);
        }
        return dp[right];
    }
}
