public class Solution {
    public int CountSubstrings(string s) {
        var dp = new bool[s.Length][];
        for(int i = 0; i < s.Length; i++){
            dp[i] = new bool[s.Length];
        }
        
        var result = 0;
        for(int i = s.Length -1; i >=0; i--){
            for(int j = i; j < s.Length; j++){
                if(s[i] == s[j]){
                    if(j - i <= 1){
                        result++;
                        dp[i][j] = true;
                    }
                    else if(dp[i+1][j-1]){
                        result++;
                        dp[i][j] = true;
                    }
                }
            }
        }
        return result;
    }
}
