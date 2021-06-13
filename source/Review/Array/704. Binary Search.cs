public class Solution {
    public int Search(int[] nums, int target) {
        int low = 0;
        int high = nums.Length - 1;
        int result = 0;
        while(low < high){
            var mid = low + (high-low+1) / 2;
            if(nums[mid] > target)
            {
                high = mid -1;
            }
            else
            {
                low = mid;
            }
        }
        return nums[low] != target ? -1 : low;
    }
}
