public class Solution {
    ///Runtime: 294 ms, faster than 39.04% of C# online submissions for Jump Game.
    ///Memory Usage: 40.3 MB, less than 38.42% of C# online submissions for Jump Game.
    public bool CanJump(int[] nums) {
        int lastPos = nums.Length - 1;
        for (int i = nums.Length - 2; i >= 0; i--) {
            if (i + nums[i] >= lastPos) {
                lastPos = i;
            }
        }
        return lastPos == 0;
    }
    
    ///Runtime: 314 ms, faster than 35.80% of C# online submissions for Jump Game.
    ///Memory Usage: 40.4 MB, less than 30.57% of C# online submissions for Jump Game.
    public bool CanJump2(int[] nums) {
        int n = nums.Length;
        int i = 0;
        for (int reach = 0; i < n && i <= reach; i++) {
            reach = Math.Max(i + nums[i], reach);
        }
        return i == n;
    }
    
    ///Runtime: 192 ms, faster than 55.42% of C# online submissions for Jump Game.
    ///Memory Usage: 40.8 MB, less than 23.04% of C# online submissions for Jump Game.
    public bool CanJump3(int[] nums) {
        int n = nums.Length;
        int farest = 0;
        for (int i = 0; i < n; i++) {
            if(farest < i )
                return false;
            farest = Math.Max(i + nums[i], farest);
        }
        return true;
    }    

}
