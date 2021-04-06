public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int result = 0;
        int tempResult = 0;
        int minIndex = -1;
        Dictionary<char, int> dic = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++){
            char nextChar = s[i];
             Console.WriteLine("i=>" + i.ToString() + "nextChar" + nextChar.ToString());
            if(dic.TryGetValue(nextChar, out int charIndex) && charIndex >= minIndex){
                minIndex= charIndex + 1;
                Console.WriteLine("i, charIndex=>" + i.ToString() +" "+ charIndex.ToString());
                Console.WriteLine("tempResult=>" + tempResult.ToString());
                tempResult = i - minIndex + 1;
            }
            else{
                tempResult++;
            }
            dic[nextChar] = i;
            if(tempResult > result)
            {
                result = tempResult;
            }
        }
     
        return result;
    }
}
