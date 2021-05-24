public class Solution {
    public int FindMin(int[] nums) {
         if (nums[0] < nums[nums.Length - 1])
             return nums[0];
         int start = 0;
         int end = nums.Length - 1;
         var result = nums[0];
         while (start < end)
         {
             int mid = (start + end) / 2;
             if (nums[mid] >= nums[start])
             {
                 start = mid + 1;
             }
             else
             {
                 end = mid;
             }
             result = Math.Min(result, Math.Min(nums[start], nums[end]));
         }
         return result;
    }
}
