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
    public int SumOfLeftLeaves(TreeNode root) {
        var list = new List<int>();
        Helper(list, root);
        return list.Sum();
    }
    
    public void Helper(List<int> list, TreeNode node){
        if(node == null)
            return;
        if(node.left != null && node.left.left == null && node.left.right == null)
            list.Add(node.left.val);
        Helper(list, node.left);
        Helper(list, node.right);
    }
    
    
}
