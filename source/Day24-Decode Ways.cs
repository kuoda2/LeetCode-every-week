public class Solution {
    public int NumDecodings(string s) {
        var list = GetSecList(s);
        var result = 1;
        for(int i = 0; i < list.Count();i++){
            result *= GetNumDecoding(list[i]);
        }
        return result;
        
   }
    public List<string> GetSecList(string s){

    int lastIndex = 0;
    var result = new List<string>();
    for(int i = 0; i < s.Length; i++){
      if(s[i] == '1' || s[i] == '2'){
        if(i != s.Length -1)
          continue;
        else
        result.Add(s.Substring(lastIndex, i - lastIndex +1));
      }
      else{
        result.Add(s.Substring(lastIndex, i- lastIndex + 1));
        lastIndex = i+1;
      }
    }
    return result;

  }
    
    public static int GetNumDecoding(string s){
          int result = 0;
        int lastResult = 1;
        int lastAdd = 1;
        if(s == "0")
            return result;
        char lastChar = s[0];
        HashSet<char> fitOne = new HashSet<char>();
        HashSet<char> fitTwo = new HashSet<char>();
        for(int i = 1; i < 10; i++){
            fitOne.Add(i.ToString()[0]);
        }
        
        for(int i = 1; i < 7;i++){
            fitTwo.Add(i.ToString()[0]);
        }
        if(lastChar != '0')
            result++;
        for(int i = 1 ; i < s.Length; i++){
            var currentChar = s[i];
            if(lastChar == '1')
            {
                if(fitOne.Contains(currentChar)){
                    var temp = result;
                    result += lastResult;
                    lastAdd = lastResult;
                    lastResult = temp;
                }
                else if(currentChar == '0'){
                    var temp = result;
                    if(result > 1)
                        result -= lastAdd;
                    //lastResult = temp;
                }
            }
            else if (lastChar == '2'){
                if(fitTwo.Contains(currentChar)){
                    var temp = result;
                    result += lastResult;
                    lastAdd = lastResult;

                    lastResult = temp;
                }
                else if(currentChar == '0'){
                    var temp = result;
                    if(result > 1)
                        result -= lastAdd;
                    //lastResult = temp;
                }
            }
            else if( currentChar == '0')
                return 0;
            lastChar = currentChar;
        }
         return result;   
    }

}
