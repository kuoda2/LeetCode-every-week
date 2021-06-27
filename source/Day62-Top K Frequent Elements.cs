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
        var result = new Dictionary<int, List<int>>();
        var distinctCount = new List<int>();
        foreach(int key in map.Keys){
            var v = map[key];
            if(result.ContainsKey(v))
                result[v].Add(key);
            else{
                result[v] = new List<int>(){key};
                distinctCount.Add(v);
            }
        }
        var finalResult = new List<int>();
        distinctCount.Sort();
        for(int i = distinctCount.Count - 1 ; k > 0 && i >= 0;i--){
           for (int j = 0; j < result[distinctCount[i]].Count; j++)
           {
               finalResult.Add(result[distinctCount[i]][j]);
               k--;
           }
        }
        return finalResult.ToArray();
    }
}
