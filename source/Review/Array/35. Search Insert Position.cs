public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int lo = 0;
        int hi = nums.Length;
        while(lo < hi){
            var mid = lo + (hi - lo) / 2;
            if(nums[mid] >= target)
                hi = mid;
            else
                lo = mid + 1;

        }
        return hi;
    }
}
