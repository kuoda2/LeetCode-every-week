public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dic = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++){
            int nextValue = nums[i];
            int lookUpValue = target - nextValue;
            if(dic.TryGetValue(lookUpValue, out int index)){
                return new int[2]{i, index};
            }
            dic[nextValue] = i;
        }
        return new int[0]{};
    }
}
