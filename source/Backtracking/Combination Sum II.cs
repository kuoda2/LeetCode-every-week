public class Solution {
    List<IList<int>> result = new List<IList<int>>();
    List<int> list = new List<int>();
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        BackTracking(candidates, target, 0);
        return result;
        
    }
    
    public void BackTracking(int[] candidates, int remaining, int startIndex){
        if(remaining == 0){
            result.Add(list.ToList());
        }
        else{
            for(int i=startIndex; i < candidates.Length; i++){
                if(remaining - candidates[i] < 0)
                    break;
                if(i != startIndex && i > 0 && candidates[i] == candidates[i-1])
                    continue;
                    
                list.Add(candidates[i]);
                BackTracking(candidates, remaining - candidates[i], i+1);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
