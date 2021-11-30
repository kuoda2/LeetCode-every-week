public class Solution {
    public int FindLength(int[] nums1, int[] nums2) {
        var n1 = nums1.Length;
        var n2 = nums2.Length;
        var dp = Enumerable.Range(0, n1+1)
                    .Select(x => Enumerable.Repeat(0, n2+1).ToArray()).ToArray();
        var result = -1;
        for(int i = 1; i <= n1; i++){
            for(int j = 1; j <= n2; j++){
                if(nums1[i - 1] == nums2[j - 1]){
                    dp[i][j] = dp[i-1][j-1] + 1;
                }
                if(dp[i][j] > result)
                    result = dp[i][j];
            }
        }
        return result;
    }
}
