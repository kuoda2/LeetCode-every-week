public class Solution {
    public bool IsValid(string s) {
          if(s.Length % 2 != 0)
            return false;
        
        Stack<char> stack = new Stack<char>();
        HashSet<char> left = new HashSet<char>(){'{','[','('};
        HashSet<char> right = new HashSet<char>(){'}',']','}'};
        var index = 0;
        while(index < s.Length){
            var current = s[index];
            if(left.Contains(current)){
                stack.Push(current);
            }
            else
            {
                if(stack.Count == 0)
                    return false;
                var candidate = stack.Pop();
                if(!IsSameType(new char[]{current, candidate}))
                    return false;
            }
            index++;
        }
        if(stack.Count > 0)
            return false;
        return true;
        
    }
    static char[] type1 = new char[]{'(',')'};
    static char[] type2 = new char[]{'{','}'};
    static char[] type3 = new char[]{'[',']'};
    
    private static bool IsSameType(char[] source){
        Array.Sort(source);
        
        if((source[0] == type1[0] && source[1] == type1[1]) 
           || (source[0] == type2[0] && source[1] == type2[1]) 
           || (source[0] == type3[0] && source[1] == type3[1]) )
            return true;
        else
            return false;
    }
}
