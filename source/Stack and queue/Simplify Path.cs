public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> stack = new Stack<string>();
        string[] pathArray = path.Split('/');
        for(int i = 0 ; i < pathArray.Length; i++){
            var p = pathArray[i];
            if(p == "." || p == string.Empty)
                continue;
            else if(p == ".."){
                if(stack.Count > 0)
                    stack.Pop();
            }
            else
                stack.Push(p);
        }
        if(stack.Count == 0)
            return "/";
        else
        {
            var result = "";
            while(stack.Count > 0){
                result = $"/{stack.Pop()}" + result;
            }
            return result;
        }
    }
}
