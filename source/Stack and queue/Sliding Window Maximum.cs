public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if (nums.Length == 0)
            return new int[0];
        if (k == 1)
            return nums;
        if (k == nums.Length)
            return new int[] { nums.Max() };
        
        int len = nums.Length;
        int s = k - 1;
        
        int[] ltr = new int[len];
        int[] rtl = new int[len];
        
        ltr[0] = nums[0];
        rtl[len-1] = nums[len-1];
        
        for (int i = 1, j = len-2; i < len; i++, j--) {
            ltr[i] = (i % s > 0) ? Math.Max(nums[i], ltr[i-1]) : nums[i];
            rtl[j] = ((j+1) % s > 0) ? Math.Max(nums[j], rtl[j+1]) : nums[j];
        }
        
        int[] result = new int[len-k+1];
        for (int i = 0; i < len-k+1; i++)
            result[i] = Math.Max(rtl[i], ltr[i+k-1]);
        
        return result;
    }
}
