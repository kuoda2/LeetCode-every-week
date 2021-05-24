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
public class Solution2 {
    public void ReorderList(ListNode head) {
        if (head == null || head.next == null)
            return;

        ListNode pre = null, slow = head, fast = head, l1 = head;

        while (fast != null && fast.next != null)
        {
            pre = slow;
            slow = slow.next;
            fast = fast.next.next;
        }

        pre.next = null;

        var l2 = Reverse(slow);

        Merge(l1, l2);
    }

    public ListNode Reverse(ListNode head){
        ListNode prev = null, curr = head, next = null;

        while (curr != null)
        {
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        return prev;
    }

    public void Merge(ListNode head1, ListNode head2){
        while (head2 != null)
        {
            var next = head1.next;
            head1.next = head2;
            head1 = head1.next;
            head2 = next;
        }
    
    }
}
