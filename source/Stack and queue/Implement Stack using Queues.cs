public class MyStack {
    Queue<int> queue1;
    Queue<int> queue2;
    /** Initialize your data structure here. */
    public MyStack() {
        queue1 = new Queue<int>();
        queue2 = new Queue<int>();
    }
    
    /** Push element x onto stack. */
    public void Push(int x) {
        var queue = GetLongQueue();
        queue.Enqueue(x);
    }
    
    /** Removes the element on top of the stack and returns that element. */
    public int Pop() {
        var shortQueue = GetShortQueue();
        var longQueue = GetLongQueue();
        while(longQueue.Count > 1){
            shortQueue.Enqueue(longQueue.Dequeue());
        }
        var result = longQueue.Dequeue();
        return result;
    }
    
    /** Get the top element. */
    public int Top() {
        var result = Pop();
        var longQueue = GetLongQueue();
        longQueue.Enqueue(result);
        return result;
    }
    
    /** Returns whether the stack is empty. */
    public bool Empty() {
        return queue1.Count == 0 && queue2.Count == 0;
    }
    
    private Queue<int> GetLongQueue(){
        if(queue1.Count > queue2.Count)
            return queue1;
        else 
            return queue2;
    }
    private Queue<int> GetShortQueue(){
        if(queue1.Count > queue2.Count)
            return queue2;
        else 
            return queue1;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
