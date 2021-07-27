public class Solution {
    public int StrStr(string haystack, string needle) {
        if(needle == "")
            return 0;
        var result = -1;
        
        for(int i = 0; i < haystack.Length; i++){
            var tempResult = i;
            var from = i;
            var to = i + needle.Length -1;
            var from2 = 0;
            var to2 = needle.Length -1;
                
            if(to > haystack.Length - 1)
                return result;
            
            while(haystack[from] == needle[from2] && haystack[to] == needle[to2]){
                from++;
                to--;
                from2++;
                to2--;
                if(from > to)
                    return tempResult;
            }
        }
        return result;
    }
}
