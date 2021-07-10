public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        if(ransomNote.Length > magazine.Length)
            return false;
        int[] mArray = new int[26];
        for(int i = 0; i < magazine.Length; i++){
            mArray[magazine[i] - 'a']++;
        }
        for(int i = 0; i < ransomNote.Length; i++){
            mArray[ransomNote[i] - 'a']--;
        }
        for(int i = 0; i < mArray.Length; i++){
            if(mArray[i] < 0)
                return false;
        }
        return true;
    }
}
