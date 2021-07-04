public class Solution {
    int result = 0;
    public int CountSubstrings(string s) {
        if(s == null || s.Length == 0)
            return 0;
        for(int i = 0; i < s.Length; i ++){
            helper(s, i, i);
            helper(s, i, i+1);
        }
        return result;
    }
    public void helper(string s, int left, int right){
        while(left >= 0 && right < s.Length && s[left] == s[right]){
            result++;
            left--;
            right++;
        }
    }
}
