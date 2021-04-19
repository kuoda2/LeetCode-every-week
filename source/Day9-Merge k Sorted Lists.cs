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
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists.Length == 0)
            return null;
        ListNode result = lists[0];
         if(lists.Length < 2)
            return result;
        for(int i = 0; i+1 < lists.Length; i++){
            result = MergeTwoLists(result, lists[i+1]);
        }
        return result;
    }
    
     public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        
        // get tempThread
        // get next till val > tempThread
        // if tempThread is null then over

        if(l1 == null && l2 == null)
            return null;
        if(l1 == null)
            return l2;
        if(l2 == null)
            return l1;
        var l1Current = FindLast(l1,l1);
        var l2Current = FindLast(l2,l2);
        var tempThreshold = l1Current.val > l2Current.val ? l1 : l2;
        var currentNode = l1Current.val > l2Current.val ? l2Current : l1Current;
        var result = currentNode == l2Current ? l2 : l1;
        while(tempThreshold != null){
            var temp = FindLast(currentNode, tempThreshold);
            currentNode = tempThreshold;
            
            tempThreshold = temp.next;
            temp.next = currentNode;
        }
        return result;
        
    }
    public ListNode FindLast(ListNode l, ListNode tempThreshold){
        while( l?.next?.val <= tempThreshold.val){
            l = l.next;
        }
        return l;
    }
}Merge k Sorted Lists
