public class Solution {
    public bool IsSubsequence(string s, string t) {
        var dp = new int[s.Length+1][];
        for(int i = 0; i < s.Length +1; i++){
            dp[i] = new int[t.Length+1];
        }
        var result = 0;
        for(int i = 1; i <= s.Length; i++){
            for(int j = 1; j <= t.Length; j++){
                if(s[i-1] == t[j-1]){
                    dp[i][j] = dp[i-1][j-1] +1;
                }
                else{
                    dp[i][j] = Math.Max(dp[i-1][j], dp[i][j-1]);
                }
            }
        }
        return dp[s.Length][t.Length] == s.Length;
    }
}
