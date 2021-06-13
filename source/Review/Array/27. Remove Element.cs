public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int i = 0;
        int n = nums.Length;
        while(i < n){
            if(nums[i] == val){
                nums[i] = nums[n - 1];
                n--;
            }
            else{
                i++;
            }
        }
        return n;
    }
}

public class Solution2 {
    public int RemoveElement(int[] nums, int val) {
        int i = 0;
        int n = nums.Length;
        for(int j = 0; j < n; j++){
            if(nums[j] != val)
            {
                nums[i] = nums[j];
                i++;
            }
        }
        return i;
    }
}
