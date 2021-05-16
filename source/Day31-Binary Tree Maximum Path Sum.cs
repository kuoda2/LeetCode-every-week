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
    public int MaxPathSum(TreeNode root) {
        int ans = int.MinValue;
        helper(root, ref ans);
        return ans;
    }
    
    public int helper(TreeNode node, ref int ans){
        if(node == null)
            return 0;
        var l = Math.Max(helper(node.left, ref ans), 0);
        var r = Math.Max(helper(node.right, ref ans), 0);
        var sum = node.val + l + r;
        ans = Math.Max(sum, ans);
        return Math.Max(l, r) + node.val;
    }
}
