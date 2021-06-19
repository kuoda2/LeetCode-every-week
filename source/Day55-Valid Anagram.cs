public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        Dictionary<char,int> map = new Dictionary<char,int>();
        for(int i = 0;i<s.Length; i++){
            if(map.TryGetValue(s[i],out int val)){
                map[s[i]]++;
            }else{
                map[s[i]] = 1;
            }
        }
        for(int i = 0;i<t.Length; i++){
            if(map.TryGetValue(t[i],out int count)){
                if(count < 1)
                    return false;
                map[t[i]]--;
            }
            else{
                return false;
            }
        }
        return true;
    }
}
