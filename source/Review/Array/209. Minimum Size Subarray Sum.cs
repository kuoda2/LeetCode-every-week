public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int result = Int32.MaxValue;
        int sum = 0;
        int j = 0;
        for(int i=0; i<nums.Length;i++){
            sum += nums[i];
            while(sum >= target){
                result = Math.Min(result, i - j + 1);
                sum -= nums[j];
                j++;
            }
        }
        return result == Int32.MaxValue ? 0 : result;
    }
}
