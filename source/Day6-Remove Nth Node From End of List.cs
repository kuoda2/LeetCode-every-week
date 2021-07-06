/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(head.next == null)
            return null;
        Stack<ListNode> stack = new Stack<ListNode>();
        ListNode current = head;
        int count = 0;
        while(current != null){
            stack.Push(current);
            current = current.next;
            count++;
        }
        if(count == n)
            return head.next;
        ListNode newNext = null;
        current = stack.Pop();
        while(n > 0){
            newNext = current.next;
            current = stack.Pop();
         
            n--;
        }

        current.next = newNext;
        return head;    
    }
    public ListNode Method2(ListNode head, int n){
        if(head.next ==null)
            return null;
        Stack<ListNode> stack = new Stack<ListNode>();
        var curr = head;
        while(curr!=null){
            stack.Push(curr);
            curr = curr.next;
        }
        int i = 0;
        ListNode toRemove = null;
        while(i!=n){
            i++;
            toRemove = stack.Pop();
        }
        var next = toRemove.next;
        if(stack.Count == 0)
            return next;
        var preNode = stack.Pop();
        preNode.next = next;
        return head;
    }
    public ListNode Method3(ListNode head, int n){
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode first = dummy;
        ListNode second = dummy;
        for(int i = 0; i <= n; i++){
            first = first.next;
        }
        while(first != null){
            first = first.next;
            second = second.next;
        }
        second.next = second.next.next;
        return dummy.next;
    }
}
