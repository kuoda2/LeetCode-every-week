public class MyQueue {

    Stack<int> stack1;
    Stack<int> stack2;
    /** Initialize your data structure here. */
    public MyQueue() {
        stack1 = new Stack<int>();
        stack2 = new Stack<int>();
    }
    
    /** Push element x to the back of queue. */
    public void Push(int x) {
        stack1.Push(x);
    }
    
    /** Removes the element from in front of queue and returns that element. */
    public int Pop() {
        var result = Peek();
        stack2.Pop();
        return result;
        
    }
    
    /** Get the front element. */
    public int Peek() {
            if(stack2.Count == 0){
            while(stack1.Count > 0){
            stack2.Push(stack1.Pop());
            }
            return stack2.Peek();
        }
        else{
            return stack2.Peek();
        } 
    }
    
    /** Returns whether the queue is empty. */
    public bool Empty() {
        return stack2.Count == 0 && stack1.Count ==0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
