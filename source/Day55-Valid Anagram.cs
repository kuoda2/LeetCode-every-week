public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        int[] array = new int[26];
        for(int i = 0;i<s.Length; i++){
            array[s[i] - 'a']++;
            array[t[i] - 'a']--;
        }
        for(int i = 0; i < array.Length;i++){
            if(array[i] != 0)
                return false;
        }
        return true;
    }
}
