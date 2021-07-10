public class Solution {
    public bool IsHappy(int n) {
        return IsHappy(n, new HashSet<int>());
    }
    
    public bool IsHappy(int n, HashSet<int> hashset){
        if(hashset.Contains(n))
            return false;
        hashset.Add(n);
        if(n == 1)
            return true;
        var newNumber = helper(n);
        return IsHappy(newNumber, hashset);
    }
    
    public int helper(int n){
        var result = 0;
        while (n > 0)
        {
            var digit = n % 10;
            n /= 10;
            result += digit * digit;
        }
        return result;
        
    }
}
