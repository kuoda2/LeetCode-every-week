public class Solution {
    public int MaxSubArray(int[] nums) {
        int sum = 0;
        int result = int.MinValue;
        for(int i = 0; i < nums.Length; i++){
            sum+=nums[i];
            result = Math.Max(result, sum);
            if(sum <= 0)
                sum = 0;
        }
        return result;
    }
}
