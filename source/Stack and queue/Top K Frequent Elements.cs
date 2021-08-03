public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(map.ContainsKey(nums[i]))
                map[nums[i]]++;
            else
                map[nums[i]] = 1;
        }
        List<int>[] list = new List<int>[nums.Length + 1];
        
        foreach(int key in map.Keys){
           if(list[map[key]] == null)
               list[map[key]] = new List<int>();
            list[map[key]].Add(key);
        }
        var result = new List<int>();
        for(int i = nums.Length ; k > result.Count && i >= 0;i--){
            if(list[i] != null)
                result.AddRange(list[i]);
        }
        return result.ToArray();
    }
}
