public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        Queue<char> queue = new Queue<char>();
        Stack<char> stack = new Stack<char>();
        for(int i=0; i < s.Length; i++){
            int charInt = Convert.ToInt32(s[i]);
            if((charInt>= 97 && charInt<= 122) ||
                (charInt>= 48 && charInt<=57))
            {
                //Console.WriteLine(charInt.ToString() + s[i]);
                queue.Enqueue(s[i]);
                stack.Push(s[i]);
            }
        }
       
        for(int i =0; i<stack.Count; i++){
            if(stack.Pop() != queue.Dequeue()){
                return false;
            }
        }
        return true;
    }
}
