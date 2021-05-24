public class Solution {
    public void ReorderList(ListNode head) {
         Stack<ListNode> stack = new Stack<ListNode>();
         Queue<ListNode> queue = new Queue<ListNode>();
         bool isQueue = true;
         int count = 0;
         while (1 > 0)
         {
             if (head == null)
                 break;
             count++;
             queue.Enqueue(head);
             stack.Push(head);
             isQueue = !isQueue;
             head = head.next;
         }

         var newHead = queue.Dequeue();
         isQueue = false;
         while (count > 0)
         {
             if (isQueue)
                 newHead.next = queue.Dequeue();
             else
                 newHead.next = stack.Pop();
             isQueue = !isQueue;
             newHead = newHead.next;
             count--;
         }
    }
}
