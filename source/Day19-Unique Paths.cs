public class Solution {
    public int UniquePaths(int m, int n) {
        m -= 1;
        n -= 1;
        var min = Math.Min(m,n);
        var sum = m + n;
        var result  =  1.0m;
        for(int i = min; i > 0; i--){
            result = result * sum / i;
            sum--;
        }
        return (int)Math.Round(result);
        
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
