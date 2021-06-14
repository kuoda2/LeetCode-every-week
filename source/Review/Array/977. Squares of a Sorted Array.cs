public class Solution {
    public int[] SortedSquares(int[] nums) {
        int k = nums.Length;
        int i = 0;
        int j = k - 1;
        int[] result = new int[k];
        while(k > 0){
            if(nums[i] * nums[i] > nums[j] * nums[j]){
                result[--k] = nums[i] * nums[i];
                i++;
            }
            else{
                result[--k] = nums[j] * nums[j];
                j--;
            }
        }
        
        return result;
    }
}
