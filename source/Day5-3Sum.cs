public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var result = new List<IList<int>>();
        if(nums.Length < 3)
            return result;
        Array.Sort(nums);
        
        var len = nums.Length;
        Dictionary<int, int> values = new Dictionary<int,int>();
        int index = len - 1;
        while(index >= 0){
            if (!values.ContainsKey(nums[index]))
                values.Add(nums[index], index);
            index--;
        }

        for(int i = 0; i < len; i++){
            if(i > 0 && nums[i-1] == nums[i])
                continue;
            
            for(int j = i + 1; j < len; j++){
               if(j > i + 1 && nums[j-1] == nums[j])
                    continue;
                
                var targetValue = 0 - nums[i] - nums[j];
                if(values.ContainsKey(targetValue))
                {
                    var idx = values[targetValue];
                    if(idx > i && idx > j)
                        result.Add(new int[]{nums[i], nums[j] , nums[idx]});
                }
            }
        }
        return result;
    }              
}
