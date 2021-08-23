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
    public bool IsBalanced(TreeNode root) {
        if(root == null)
            return true;
        var left = GetHeight(root.left);
        var right = GetHeight(root.right);
        
        return Math.Abs(left - right) <=1 && IsBalanced(root.left) && IsBalanced(root.right);
    }
    
    public int GetHeight(TreeNode node){
        if(node == null)
            return 0;
        return Math.Max(GetHeight(node.left), GetHeight(node.right)) + 1;
    }
}
