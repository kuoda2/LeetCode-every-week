public class Solution {
//Time Limit Exceeded
    public IList<IList<int>> ThreeSum(int[] nums) {
        var result = new List<IList<int>>();
        if(nums.Length < 3)
            return result;
        Dictionary<int, List<int>> dic = new Dictionary<int,List<int>>();
        int index = 0;
        while(index < nums.Length - 1){
            if(dic.TryGetValue(nums[index], out List<int> list))
            {
                list.Add(index);
            }
            else
                dic[nums[index]] = new List<int>(index);
        }
        
        int i = 0;
        while(i < nums.Length - 2){
            var x = nums[i];
            var j = i + 1;
            while(j < nums.Length -2)
            {
                var y = nums[j];
                var targetValue = 0 - x - y;
                if(dic.TryGetValue(targetValue, out List<int> indexList))
                {
                    var count = 0;
                    while(count < indexList.Count() - 1)
                    {
                        result.Add(new List<int>(){i, j, indexList[count]});
                        count++;
                    }
                    
                }
                j++;
            }
            
            i++;
        }
    return result;
    }
    
                   
}
