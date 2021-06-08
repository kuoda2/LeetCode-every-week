/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    Stack<int> stack = new Stack<int>();
    public int KthSmallest(TreeNode root, int k) {
        InOrder(root,k);
        var result = stack.Pop();
        return result;
    }
    
    public void InOrder(TreeNode node, int k){
        if(node == null)
            return;
       
        InOrder(node.left,k);
         if(stack.Count() == k)
            return;
        stack.Push(node.val);
        InOrder(node.right,k);
            
    }
}
