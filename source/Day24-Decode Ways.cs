public class Solution {
    public int NumDecodings(string s) {
        
        int result = 0;
        int lastResult = 1;
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
                    lastResult = temp;
                }
                else if(currentChar == '0'){
                    var temp = result;
                    if(result > 1)
                        result -= lastResult;
                    //lastResult = temp;
                }
            }
            else if (lastChar == '2'){
                if(fitTwo.Contains(currentChar)){
                    var temp = result;
                    result += lastResult;
                    lastResult = temp;
                }
                else if(currentChar == '0'){
                    var temp = result;
                    if(result > 1)
                        result -= lastResult;
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
