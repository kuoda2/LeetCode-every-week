public class Solution {
    public bool CanPartition(int[] nums) {
        int sum = 0;
        for(int i = 0; i < nums.Length; i++){
            sum += nums[i];
        }
        
        var remain = sum % 2;
        if(remain != 0)
            return false;
        var dp = new int[20001];
        
        var target = sum / 2;
        
        for(int i = 0; i < nums.Length; i++){
            for(int j = target; j >= nums[i]; j--){
                dp[j] = Math.Max(dp[j], dp[j - nums[i]] + nums[i]);
            }
        }
        if(dp[target] == target)
            return true;
        return false;
    }
}
