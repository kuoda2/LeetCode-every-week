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
    public IList<IList<int>> ThreeSum2(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums.Length < 3)
                return result;
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                // avoid duplicate
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                var left = i + 1;
                var right = nums.Length - 1;
                while (right > left)
                {
                    if (nums[i] + nums[left] + nums[right] > 0)
                        right--;
                    else if (nums[i] + nums[left] + nums[right] < 0)
                        left++;
                    else
                    {
                        result.Add(new[] { nums[i], nums[left], nums[right] });
                        // avoid duplicate
                        while (right > left && nums[right] == nums[right - 1]) right--;
                        while (right > left && nums[left] == nums[left + 1]) left++;
                        
                        right--;
                        left++;
                    }
                }
            }
            return result;
        }
}
