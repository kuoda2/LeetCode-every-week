public class Solution {
    List<IList<int>> result = new List<IList<int>>();
    Stack<int> stack = new Stack<int>();
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        Array.Sort(candidates);
        Backtracking2(candidates, target, 0);
        return result;
    }
    
    public void Backtracking(int[] candidates, int target, int indexFrom){
        if(stack.Sum() == target)
            result.Add(stack.ToList());
        
        for(int i = indexFrom; i < candidates.Length; i++){
            if(stack.Sum() > target)
                continue;
            
            stack.Push(candidates[i]);
            Backtracking(candidates, target, i);
            stack.Pop();
                
        }
    }

    public void Backtracking2(int[] candidates, int remain, int indexFrom){
        if(remain < 0)
            return;
        else if( remain == 0){
            result.Add(stack.ToList());
        }
        else{
            for(int i = indexFrom; i < candidates.Length; i++){
                stack.Push(candidates[i]);
                Backtracking2(candidates, remain - candidates[i], i);
                stack.Pop();

            }
        }
    }
}
