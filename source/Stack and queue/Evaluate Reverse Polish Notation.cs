public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        HashSet<string> operators = new HashSet<string>(){"+", "-", "*", "/"};
        for(int i = 0 ; i < tokens.Length; i ++){
            var c = tokens[i];
            if(operators.Contains(c)){
                var num1 = stack.Pop();
                var num2 = stack.Pop();
                if(c == "+"){
                    stack.Push(num2 + num1);
                }else if(c == "-"){
                    stack.Push(num2 - num1);
                }else if(c == "*"){
                    stack.Push(num2 * num1);
                }else if(c == "/"){
                    stack.Push(num2 / num1);
                }
            }
            else{
                stack.Push(Convert.ToInt32(c));
            }
        }
        var result = stack.Pop();
        return result;
    }
}
