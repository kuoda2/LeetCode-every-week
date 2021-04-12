public class Solution {
    public string LongestPalindrome(string s) {
        
        int index = 0;
        char[] newString = new char[s.Length * 2];
        for(var i = 0; i < newString.Length; i++)
        {
            if(i % 2 == 0)
                newString[i] = s[i/2];
            else
                newString[i] = ' ';
        }
        int max = 0;
        Console.WriteLine(newString);
        for(var i = 0; i < newString.Length; i++)
        {
            for(var j = 0; i - j >= 0 && (i + j) < newString.Length ; j++)
            {
                if(newString[i - j] == newString[i + j])
                {
                    if(i == 10 && j == 2)
                    {
                        Console.WriteLine($"{i - j} =>{newString[i - j]}");
                        Console.WriteLine($"{i + j} =>{newString[i + j]}");
                    }
                    if(j > max && newString[i - j] != ' ')
                    {
                        index = i;
                        max = j;
                    }
                }
                else
                    break;
                    
            }
            
        }
        Console.WriteLine(index);
        Console.WriteLine(max);
        
        StringBuilder sb = new StringBuilder();
        
        for(var i = 0; i <= max * 2; i++){
            var currentIndex = index - max + i;
            Console.WriteLine(string.Format("{0}=>{1}",currentIndex, newString[currentIndex]));
            if(newString[currentIndex] != ' ')
            {
                sb.Append(newString[currentIndex]);
            }
        }
        
        return sb.ToString();
        
    }
}
