public class Solution {
    List<IList<int>> result = new List<IList<int>>();
    public IList<IList<int>> PermuteUnique(int[] nums) {
        Array.Sort(nums);
        BackTracking(nums, new List<int>());
        return result;
    }
    
    public void BackTracking(int[] nums, List<int> list)
    {
        if(nums.Length == 0){
            result.Add(list.ToList());
            return;
        }
        
        for(int i = 0; i<nums.Length;i++){
            if(i != 0 && nums[i] == nums[i - 1])
                continue;
            list.Add(nums[i]);
            var nextNums = nums.ToList();
            nextNums.RemoveAt(i);
            BackTracking(nextNums.ToArray(), list);
            list.RemoveAt(list.Count - 1);
        }
    }
}
