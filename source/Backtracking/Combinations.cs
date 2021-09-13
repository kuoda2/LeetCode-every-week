public class Solution {
    List<IList<int>> result = new List<IList<int>>();
    Stack<int> stack = new Stack<int>();
    bool[] choosed = new bool[21];
    public IList<IList<int>> Combine(int n, int k) {
        return Combine(n,k,1);
    }
    public IList<IList<int>> Combine(int n, int k, int j) {

        if(stack.Count == k)
            result.Add(stack.ToList());
        
        for(int i = j; i < n+1; i++){
            if(!choosed[i]){
                stack.Push(i);
                choosed[i] = true;
                Combine(n, k,i+1);
                stack.Pop();
                choosed[i]=false;
            }
        }
        return result;
    }
}
