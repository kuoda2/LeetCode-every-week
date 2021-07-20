public class Solution {
   public string ReverseWords(string s)
   {
       var result = string.Empty;
       List<char> list = new List<char>();
       Stack<string> stack = new Stack<string>();
       for (int i = 0; i < s.Length; i++)
       {
           if (s[i] == ' ')
           {
               if (list.Count > 0)
               {
                   stack.Push(new string(list.ToArray()));
                   list.Clear();
               }
           }
           else
           {
               list.Add(s[i]);
           }
       }
       if(list.Count > 0)
           stack.Push(new string(list.ToArray()));
       
       if (stack.Count > 0)
       {
           result = string.Join(" ", stack);
       }
       return result;
   }
}
