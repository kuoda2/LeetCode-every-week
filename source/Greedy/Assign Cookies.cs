public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);
        Stack<int> stack = new Stack<int>();
        Dictionary<int, int> map = new Dictionary<int, int>();
        int result = 0;
        for(int i = 0; i < s.Length; i++){
            if(map.TryGetValue(s[i], out int count)){
                map[s[i]]++;
            }
            else{
                map[s[i]] = 1;
                stack.Push(s[i]);
            }
        }
        
        for(int i = g.Length -1; i >= 0; i--){
            if(stack.Count == 0)
                break;
            var content = g[i];
            
            var cookie = stack.Peek();
            if(cookie >= content){
                result++;
                map[cookie]--;
                if(map[cookie] == 0)
                    stack.Pop();
            }
        }
        return result;
    }
}
