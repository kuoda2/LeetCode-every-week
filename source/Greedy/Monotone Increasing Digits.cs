public class Solution {
    public int MonotoneIncreasingDigits(int n) {
        if(n < 2) return n;
        var pre = int.MaxValue;
        var offset = 1;
        var result = 0;
        while(n != 0){
            var digit = n % 10;
            if(digit > pre){
                result = digit * offset - 1;
                pre = digit - 1;
            }
            else{
                result = result + digit * offset;
                pre = digit;
            }
            offset *= 10;
            n /= 10;
        }
        return result;
    }
}
