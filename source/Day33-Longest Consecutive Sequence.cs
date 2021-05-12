public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> hashSet = new HashSet<int>();
        for(int i = 0; i< nums.Length; i++){
            hashSet.Add(nums[i]);
        }
        
        int longest = 0;
        
        for(int i = 0; i < nums.Length; i++){
            if(!hashSet.Contains(nums[i] -1 )){
                int currNum = nums[i];
                int currLenght = 1;
                while(hashSet.Contains(++currNum)){
                    currLenght++;
                }
                longest = Math.Max(longest, currLenght);
            }
        }
        return longest;
    
    }
}
