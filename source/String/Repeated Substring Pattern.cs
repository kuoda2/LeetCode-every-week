public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        for(int i = 1; i <= s.Length/2;i++){
            if(s.Length %i == 0){
                var t = s.Length / i;
                List<char> list = new List<char>();
                var charArray = new char[i];
                for(int j=0; j < i;j++){
                    charArray[j] = s[j];
                }
                for(int k=0;k<t;k++){
                    list.AddRange(charArray);
                }
                var s2 = new string(list.ToArray());
                if(s2 == s)
                    return true;
            }
        }
        return false;
    }
}
