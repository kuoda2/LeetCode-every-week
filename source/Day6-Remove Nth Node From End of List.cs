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
}
