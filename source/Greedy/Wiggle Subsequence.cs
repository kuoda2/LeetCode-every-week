public class Solution {
    public int WiggleMaxLength(int[] nums) {
        if(nums.Length == 1) return nums.Length;
        var curr = 1;
        var last = nums[1] - nums[0];
        if(last != 0)
            curr++;
        for(int i = 2; i < nums.Length; i++){
            if(nums[i] - nums[i - 1] != 0 && last * (nums[i] - nums[i - 1]) <= 0)
            {
                curr++;
            }
            if(nums[i] - nums[i - 1] != 0){
                last = nums[i] - nums[i - 1];
            }
        }
        return curr;
    }
}
