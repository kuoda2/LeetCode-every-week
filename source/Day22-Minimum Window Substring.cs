public class Solution {
    public string MinWindow(string s, string t) {
        
        
        // set 
        Dictionary<char,int> targetDic = new Dictionary<char,int>();
        for(int i = 0 ; i < t.Length; i++){
            if(targetDic.ContainsKey(t[i]))
                targetDic[t[i]]++;
            else
                targetDic[t[i]] = 1;
        }
        //// Check targetDic
        //foreach(var item in targetDic){
        //   Console.WriteLine($"key:{item.Key}, value:{item.Value}");
        //}
        //Console.WriteLine(targetDic.Values.Sum());
        int left = 0, right = 0;
        int minLength = int.MaxValue;
        int index = 0;
        int matchCount = 0;
        for(int i = 0; i < s.Length; i++){
            char ch = s[i];
            if(!targetDic.TryGetValue(ch, out int count))
                continue;
            targetDic[ch]--;
            
            if(targetDic[ch] == 0){
                matchCount++;
            }
            while(matchCount == targetDic.Count){
                if(i - left + 1 < minLength){
                    minLength = i - left + 1;
                    index = left;
                }
                char leftChar = s[left++];
                if(!targetDic.TryGetValue(leftChar, out int leftCharCount))
                    continue;
                targetDic[leftChar]++;
                if(targetDic[leftChar] == 1){
                    matchCount--;
                }
            }
        }
        Console.WriteLine($"index:{index}, minLength:{minLength}");
        var result = minLength == int.MaxValue ? "" : s.Substring(index, minLength);
        Console.WriteLine(result);
        return result;
    }
}
