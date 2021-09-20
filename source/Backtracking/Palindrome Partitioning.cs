public class Solution {
    List<IList<string>> result = new List<IList<string>>();
    List<string> list = new List<string>();
    public IList<IList<string>> Partition(string s) {
        BackTracking(s, 0, string.Empty);
        return result;
    } 
    
    public void BackTracking(string s, int startIndex, string temp){
        if(startIndex > s.Length - 1)
            return;
        for(int i = startIndex; i < s.Length; i++){
            temp += s[i];
            if(IsPalindrome(temp)){
                list.Add(temp);
                if(i == s.Length - 1){
                    result.Add(list.ToList());
                }
                BackTracking(s, i+1, string.Empty);
                list.RemoveAt(list.Count - 1);                
            }
        }
    }
    public bool IsPalindrome(string s){
        if(string.IsNullOrEmpty(s))
            return false;
        for(int i = 0, j = s.Length - 1; i < s.Length / 2; i++, j--){
            if(s[i]!=s[j])
                return false;
        }
       // Console.WriteLine(s);
        return true;
    }
}
