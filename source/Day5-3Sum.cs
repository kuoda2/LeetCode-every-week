public class Solution {
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
        Dictionary<int, List<int>> secDictionary = new Dictionary<int,List<int>>();
        int i = 0;
        while(i < nums.Length - 2){
            var x = nums[i];
            
            if(secDictionary.TryGetValue(x, out List<int> secIndexList))
            {
                int secCount = 0;
                var secListLength = secIndexList.Count();
                while(secCount < secListLength - 1){
                    if(secIndexList[0] > x && secIndexList[1] > x)
                        result.Add(new List<int>(){i, secIndexList[0], secIndexList[1] });
                    secCount++;
                }                
            }
            var j = i + 1;
            while(j < nums.Length -2)
            {
                var y = nums[j];
               
                var targetValue = 0 - x - y;
                if(dic.TryGetValue(targetValue, out List<int> indexList))
                {
                    var count = 0;
                    var listLength = indexList.Count();
                    while(count < listLength - 1)
                    {
                        if(indexList[count] > j)
                        {
                            result.Add(new List<int>(){i, j, indexList[count]});
                            secDictionary[x] = new List<int>(){j, indexList[count]};
                        }
                        
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
