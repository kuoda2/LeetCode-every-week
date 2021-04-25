public class Solution {
    // Version 1
    // Wrong for Input ["abbbbbbbbbbb","aaaaaaaaaaab"]
    public IList<IList<string>> GroupAnagrams1(string[] strs) {
        List<IList<string>> result = new List<IList<string>>();
        if(strs.Length == 0)
            return result;
        Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
        for(int i = 0; i < strs.Length; i++){
            var str = strs[i];
            var hashValue = 0;
            for(int j = 0; j < str.Length; j++){
                hashValue = hashValue ^ str[j].GetHashCode();
            }
            if(dictionary.TryGetValue(hashValue, out List<int> list)){
                list.Add(i);
            }
            else{
                dictionary[hashValue] = new List<int>(){i};
            }
        }
        foreach(var k in dictionary.Keys){
            var anagrams = dictionary[k];
            List<string> groupAnagrams = new List<string>();
            for(int l = 0; l < anagrams.Count(); l++){
                groupAnagrams.Add(strs[anagrams[l]]);
            }
            result.Add(groupAnagrams);
        }
        return result;
        
    }
    
  // Version 2
  // Pass
  public IList<IList<string>> GroupAnagrams(string[] strs) {
        List<IList<string>> result = new List<IList<string>>();
        if(strs.Length == 0)
            return result;
        Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();
        for(int i = 0; i < strs.Length; i++){
            var str = strs[i];

            var newStr = SortString(str);

            if(dictionary.TryGetValue(newStr, out List<int> list)){
                list.Add(i);
            }
            else{
                dictionary[newStr] = new List<int>(){i};
            }
        }
        foreach(var k in dictionary.Keys){
            var anagrams = dictionary[k];
            List<string> groupAnagrams = new List<string>();
            for(int l = 0; l < anagrams.Count(); l++){
                groupAnagrams.Add(strs[anagrams[l]]);
            }
            result.Add(groupAnagrams);
        }
        return result;
        
    }
    public string SortString(string input)
    {
        char[] characters = input.ToArray();
        Array.Sort(characters);
        return new string(characters);
    }
  
}
