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
    public TreeNode TrimBST(TreeNode root, int low, int high) {
        // find a proper root
        if(root == null)
            return null;
        if(root.val > high)
            return TrimBST(root.left, low, high);
        if(root.val < low)
            return TrimBST(root.right, low, high);
        
        // check right
        var curr = root;
        while(curr.right != null){
            if(curr.right.val > high)
            {
                curr.right = curr.right.left;
            }
            else
                curr = curr.right;
        }
        
        // check left
        curr = root;
        while(curr.left != null){
            if(curr.left.val < low){
                curr.left = curr.left.right;
            }
            else
                curr = curr.left;
        }
        
        return root;
    }
}
