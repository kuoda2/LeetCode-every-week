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
    public int Rob(TreeNode root) {
        if(root == null)
            return 0;
        var (val1, val2) = RobTree(root);
        return Math.Max(val1, val2);
    }
    
    public (int robNodeVal, int notRobNodeVal) RobTree(TreeNode node){
        if(node == null)
            return (0, 0);
        var (robLeftNodeVal, notRobLeftNodeVal) = RobTree(node.left);
        var (robRightNodeVal, notRobRightNodeVal) = RobTree(node.right);

        // 不偷
        var notRobNodeVal = Math.Max(robLeftNodeVal, notRobLeftNodeVal) 
                 + Math.Max(robRightNodeVal, notRobRightNodeVal);
        
        // 偷
        var robNodeVal = node.val + notRobLeftNodeVal + notRobRightNodeVal;
        return (robNodeVal, notRobNodeVal);
    }
}
