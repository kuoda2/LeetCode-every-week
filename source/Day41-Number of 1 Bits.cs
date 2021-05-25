public class Solution {
    public int HammingWeight(uint n) {
        
        var result = 0;
        for(int i = 0; i <32 ; i++){
            if((n & 1) == 1)
                result++;
            n >>= 1;
        }
        return result;
    }
}
//----------
public class Solution {
    public int HammingWeight(uint n) {
        
        var result = 0;
        while(n>0){
            result += (int)(n & 1);
            n >>= 1;
        }
        return result;
    }
}
