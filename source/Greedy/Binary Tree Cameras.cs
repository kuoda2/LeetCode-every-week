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
    int result = 0;
    public int MinCameraCover(TreeNode root) {
        var rootVal = DFS(root);
        if(rootVal == -1)
            result++;

        return result;
    }
    
    public int DFS(TreeNode node){
        if(node.left == null && node.right == null)
            return -1;
        var left = 0;
        var right = 0;
        if(node.left != null){
            left = DFS(node.left);
        }
        if(node.right != null){
            right = DFS(node.right);
        }
        if(left == -1 || right == -1){
            result++;
            return 1;
        }
        if(left == 0 && right == 0){
            return -1;
        }
        if(left == 1 || right == 1){
            return 0;
        }
        return 0;
    }
}
