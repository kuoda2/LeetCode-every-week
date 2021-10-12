public class Solution {
    public int Candy(int[] ratings) {
        int n = ratings.Length;
        if(n == 1)
            return 1;
        var cookies = new int[n];

        for(int i = 0; i < n; i++){
            cookies[i] = 1;
        }
        
        for(int i = 1; i < n; i++){
            if(ratings[i] > ratings[i-1]){
                cookies[i] = cookies[i-1] + 1;
            }
        }
        var result = cookies[n - 1];
        for(int i = n - 2; i >= 0; i--){
            if(ratings[i] > ratings[i+1]){
                cookies[i] = Math.Max(cookies[i+1] + 1, cookies[i]);
            }
            result += cookies[i];
        }
        return result;
    }
}
