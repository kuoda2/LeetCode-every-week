public class Solution {
    List<IList<int>> result = new List<IList<int>>();
    List<int> list = new List<int>();
    public IList<IList<int>> FindSubsequences(int[] nums) {
        BackTracking(nums, 0);
        return result;
    }
    
    public void BackTracking(int[] nums, int startIndex){
        if(list.Count > 1)
            result.Add(list.ToList());
        
        HashSet<int> hashset = new HashSet<int>();
        for(int i = startIndex; i < nums.Length; i++){
            if(list.Count > 0 && list.Last() > nums[i])
                continue;
            if(hashset.Contains(nums[i]))
                continue;
            hashset.Add(nums[i]);
            list.Add(nums[i]);
     
            BackTracking(nums, i+1);
            list.RemoveAt(list.Count - 1);
        }
    }
}
