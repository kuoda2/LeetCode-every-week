public class Solution {
    List<IList<int>> result = new List<IList<int>>();
    bool[] choosed;
    public IList<IList<int>> Permute(int[] nums) {
        choosed = new bool[nums.Length];
        BackTracking(nums, new List<int>());
        return result;
    }
    
    public void BackTracking(int[] nums, List<int> list)
    {
        if(nums.Length == list.Count)
            result.Add(list.ToList());
        
        for(int i = 0; i<nums.Length;i++){
            if(choosed[i])
                continue;
            list.Add(nums[i]);
            choosed[i] = true;
            BackTracking(nums, list);
            list.RemoveAt(list.Count - 1);
            choosed[i] = false;
        }
    }
}
