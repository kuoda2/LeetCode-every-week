public class Solution {
    public int UniquePaths(int m, int n) {
        m -= 1;
        n -= 1;
        var min = Math.Min(m,n);
        Console.Writeline(min);
        var sum = m + n;
        var result  = GetFactorial(sum)/ GetFactorial(min) / GetFactorial(sum-min);
        
        return result;
        
    }
    
    public int GetFactorial(int num){
        var result = 1;
        for(int i=num; i > 1 ;i--)
        {
            result *= i;
        }
        return result;
    }
}
