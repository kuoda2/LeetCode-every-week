public class Solution {
    public int MissingNumber(int[] nums) {
        var expect = nums.Length;
        var sum = 0;
        for(int i = 0; i < nums.Length;i++){
            expect += i;
            sum +=nums[i];
        }
        var result = expect - sum;
        return result;
    }
}
