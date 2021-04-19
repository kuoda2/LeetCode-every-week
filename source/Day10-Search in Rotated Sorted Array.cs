public class Solution {
    public int Search(int[] nums, int target) {
        /*
        v1: for loop, i++ go through all item or meet the taret
          for(int i = 0; i < nums.Length; i++){
              Console.WriteLine(nums[i]);
              if(nums[i] == target)
                  return i;
          }
          return -1;
        v2: for loop, i++ or i-- depends on currentNum compare to target,
        
        v3: find out the section then binary search.
        */
        if(nums==null||nums.Length==0) return -1;
        
        int lo =0, hi=nums.Length-1;
        while(lo < hi){
            var mid = (lo + hi)/2;
            if((nums[mid] - nums[nums.Length-1]) * (target - nums[nums.Length-1]) > 0){
                
                if(nums[mid] < target)
                    lo = mid + 1;
                else
                    hi = mid;
            }
            else if(target > nums[nums.Length-1])
                hi = mid;
            else 
                lo = mid + 1;
        }
        if(nums[lo] == target)
            return lo;
        return -1;
    }
}
