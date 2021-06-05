public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length == 1)
            return nums[0];
        return Math.Max(Rob(nums, 0, nums.Length - 1), Rob(nums, 1, nums.Length));
    }
    
    public int Rob(int[] nums, int lo, int hi){
        int pre1 = 0;
        int pre2 = 0;
        for(int i = lo; i < hi; i++){
            var temp = pre1;
            pre1 = Math.Max(pre1, pre2 + nums[i]);
            pre2 = temp;
        }
        return pre1;
    }
}
