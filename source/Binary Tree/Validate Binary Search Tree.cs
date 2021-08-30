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
    TreeNode last;
    public bool IsValidBST(TreeNode root) {
      return Validate(root, null, null);
    }
    public bool Validate(TreeNode node, int? max, int? min){
        if(node == null)
            return true;
        if(max != null && node.val >= max || (min!=null && node.val <= min))
            return false;
        else
            return Validate(node.left, node.val, min) && Validate(node.right, max, node.val);
    }
}
