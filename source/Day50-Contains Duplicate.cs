public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> hashset = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++){
            if(hashset.Contains(nums[i]))
                return true;
            else
                hashset.Add(nums[i]);
        }
        return false;
    }
}
