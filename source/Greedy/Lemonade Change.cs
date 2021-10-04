public class Solution {
    public bool LemonadeChange(int[] bills) {
        var five = 0;
        var ten = 0;
        for(int i = 0; i < bills.Length; i++){
            if(bills[i] == 5)
                five++;
            else if(bills[i] == 10)
            {
                five--;
                ten++;
            }
            else if(bills[i] == 20)
            {
                if(ten > 0){
                    ten--;
                    five--;
                }
                else
                {
                    five -= 3;
                }
            }
            if(five < 0 || ten < 0)
                return false;
        }
        return true;
    }
}
