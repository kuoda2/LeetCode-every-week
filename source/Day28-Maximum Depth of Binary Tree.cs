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
    public int MaxDepth(TreeNode root) {
       return GetDepth(root, 0);
    }
    
    public int GetDepth(TreeNode node, int depth){
        if(node == null)
            return depth;
        depth++;
        return Math.Max(GetDepth(node.left, depth), GetDepth(node.right, depth));
    }
}
