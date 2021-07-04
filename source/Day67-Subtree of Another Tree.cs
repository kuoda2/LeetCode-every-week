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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(root == null)
            return false;
        if(IsSame(root, subRoot))
            return true;
        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }
    
    public bool IsSame(TreeNode nodeA, TreeNode nodeB){
        if(nodeA == null && nodeB == null)
            return true;
        if(nodeA == null || nodeB == null)
            return false;
        if(nodeA.val != nodeB.val)
            return false;
        return IsSame(nodeA.left, nodeB.left) && IsSame(nodeA.right, nodeB.right);
            
            
    }
}
