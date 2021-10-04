public class Solution {
    public int LargestSumAfterKNegations(int[] nums, int k) {
        var negativeNums = new List<int>();
        var min = int.MaxValue;
        var result = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] <= 0)
                negativeNums.Add(nums[i]);
            min = Math.Min(Math.Abs(nums[i]), min);
            result += nums[i];
        }
        if(negativeNums.Count > k){
          
            negativeNums.Sort();
            for(int i = 0; i < k; i++){
                result -= negativeNums[i] * 2;
            }
            return result;
        }
        else{
             if(negativeNums.Count <= k){
                result -= negativeNums.Sum() * 2;
            }
            k -= negativeNums.Count;
            if(k % 2 == 0)
                return result;
            else
                return result - 2 * min;
        }
    }
}
