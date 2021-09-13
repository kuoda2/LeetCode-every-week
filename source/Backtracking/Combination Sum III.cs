public class Solution {
    List<IList<int>> result = new List<IList<int>>();
    Stack<int> stack = new Stack<int>();
    bool[] choosed = new bool[10];
    public IList<IList<int>> CombinationSum3(int k, int n) {
        Backtracking(k, n, 1);
        return result;
    }
    
    public void Backtracking(int k, int n, int j) {
        if(stack.Count == k && stack.Sum() == n){
            result.Add(stack.ToList());
            return;
        }
        for(int i = j; i <= 9;i++){
            stack.Push(i);
            choosed[i] = true;
            Backtracking(k, n, i+1);
            stack.Pop();
            choosed[i] = false;
        }
    }
}
