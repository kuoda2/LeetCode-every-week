public class Solution {
    public string RemoveDuplicates(string s) {
        Stack<char> stack = new Stack<char>();
        foreach(var c in s){
            if(stack.Count != 0 && stack.Peek() == c)
                stack.Pop();
            else
                stack.Push(c);
        }
        var array = stack.ToArray();
        array = array.Reverse().ToArray();
        return new string(array);
    }
}
