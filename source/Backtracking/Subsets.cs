public class Solution {
    List<IList<int>> result = new List<IList<int>>();
    List<int> list = new List<int>();
    public IList<IList<int>> Subsets(int[] nums) {
        BackTracking(nums, 0);
        return result;
    }
    
    public void BackTracking(int[] nums, int startIndex){
        result.Add(list.ToList());
        
        
        for(int i = startIndex; i < nums.Length; i++){
            list.Add(nums[i]);
            BackTracking(nums, i+1);
            list.RemoveAt(list.Count - 1);
        }
    }
}
