public class Solution {
    public int FindMaxForm(string[] strs, int m, int n) {
        
        var dp = new int[m+1][];
        for(int i = 0; i < m+1; i++){
            dp[i] = new int[n + 1];
        }
        
        
        for(int i = 0 ; i < strs.Length; i++){
            int oneCount = 0, zeroCount = 0;
            foreach(var c in strs[i]){
                if(c == '0')
                    zeroCount++;
                else
                    oneCount++;
            }
            
            for(int j = m; j >= zeroCount; j--){
                for(int k = n; k >= oneCount; k--){
                    dp[j][k] = Math.Max(dp[j][k], dp[j- zeroCount][k - oneCount] + 1);
                }
            }
        }
        return dp[m][n];
    }
}
