public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var result = Enumerable.Repeat(0,temperatures.Length).ToArray();
        var stack = new Stack<int>();
        stack.Push(0);
        for(int i = 1 ; i < temperatures.Length; i++){
            if(temperatures[i] < temperatures[stack.Peek()]){
                stack.Push(i);
            }
            else if(temperatures[i] == temperatures[stack.Peek()]){
                stack.Push(i);
            }
            else{
                while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()]) { // 情况三
                    result[stack.Peek()] = i - stack.Pop();
                }
                stack.Push(i);
            }
        }
        return result;
    }
}
