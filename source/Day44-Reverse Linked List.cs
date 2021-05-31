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
    public ListNode ReverseList(ListNode head) {
        return ReverseList(head, null);
    }
    public ListNode ReverseListIteratively(ListNode head) {
         ListNode pre  = null;
         while (head != null)
         {
             var next = head.next;
             head.next = pre;
             pre = head;
             head = next;
         }
         return pre;
    }
    
    public ListNode ReverseList(ListNode head, ListNode newHead){
        if(head == null)
            return newHead;
        var next = head.next;
        head.next = newHead;
        return ReverseList(next, head);
    }
} 
