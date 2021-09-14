public class Solution {
    List<IList<int>> result = new List<IList<int>>();
    List<int> list = new List<int>();
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        BackTracking(nums, 0);
        return result;
    }
    
     public void BackTracking(int[] nums, int startIndex){
        result.Add(list.ToList());
        
        
        for(int i = startIndex; i < nums.Length; i++){
            if(i != startIndex && i > 0 && nums[i] == nums[i-1])
                continue;
            list.Add(nums[i]);
            BackTracking(nums, i+1);
            list.RemoveAt(list.Count - 1);
        }
    }
}
