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
    
    int sum = 0;
    public TreeNode ConvertBST(TreeNode root) {
        Postorder(root);
        return root;
    }
    
    public void Postorder(TreeNode node){
        if(node == null)
            return;
        Postorder(node.right);
        sum += node.val;
        node.val = sum;
        Postorder(node.left);
    }
}
