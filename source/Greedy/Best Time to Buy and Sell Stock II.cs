public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length < 2) return 0;
        var pre = prices[0];
        var result = 0;
        for(int i = 1; i < prices.Length; i++){
            if(prices[i] > pre){
                result += prices[i] - pre;
                pre = prices[i];
            }
            else{
                pre = prices[i];
            }
        }
        return result;
    }
}
