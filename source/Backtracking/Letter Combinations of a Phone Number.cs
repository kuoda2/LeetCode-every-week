public class Solution {
    List<string> result = new List<string>();
    List<char> list = new List<char>();
    int N;
    public IList<string> LetterCombinations(string digits) {
        if(digits == string.Empty)
            return result;
        N = digits.Length;
        Dictionary<int,string> map = new Dictionary<int,string>();
        for(int i = 0; i < N;i++){
            switch (digits[i])
            {
                case '2':
                    map[i] = "abc";
                    break;
                case '3':
                    map[i] = "def";
                    break;
                case '4':
                    map[i] = "ghi";
                    break;
                case '5':
                    map[i] = "jkl";
                    break;
                case '6':
                    map[i] = "mno";
                    break;
                case '7':
                    map[i] = "pqrs";
                    break;
                case '8':
                    map[i] = "tuv";
                    break;
                case '9':
                    map[i] = "wxyz";
                    break;
                    
            }
        }
        BackTracking(map, 0);
        return result;
    }
    
    public void BackTracking(Dictionary<int,string> map,int startIndex){
        if(list.Count == N){
            result.Add(new string(list.ToArray()));
            return;
        }
        for(int i = startIndex; i < N; i++){
            var s = map[i];
            for(int j = 0; j < s.Length; j++){
                var c = s[j];
                list.Add(c);
                BackTracking(map, i+1);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
