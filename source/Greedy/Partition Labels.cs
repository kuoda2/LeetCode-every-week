public class Solution {
    public IList<int> PartitionLabels(string s) {
        int[] countArray = new int[26];
        for(int i = 0; i < s.Length; i++){
            countArray[s[i] - 'a']++;
        }
        var result = new List<int>();
        var resultDetail = 0;
        var hashSet = new HashSet<char>();
        var left = 0;
        
        for(int i = 0 ; i < s.Length; i++){
            if(!hashSet.Contains(s[i])){
                left += countArray[s[i] - 'a'];
                hashSet.Add(s[i]);
            }
            left--;
            resultDetail++;
            if(left == 0 || i == s.Length - 1){
                result.Add(resultDetail);
                resultDetail = 0;
            }
        }
        return result;
    }
}
