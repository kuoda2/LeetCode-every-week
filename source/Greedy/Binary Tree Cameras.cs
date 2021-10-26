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
        // if no camera from child, then put a camera
        if(rootVal == -1)
            result++;

        return result;
    }
    //  Approach:-
    //In DFS if the node is a leaf node, then return -1 to the parent
    //If we have put a camera on the current node then return +1 to parent
    //If we have not put a camera on the current node then return 0 to the parent
    //If we received -1 from any of your children then put a camera
    //If we received 1 from any of your children then don't put a camera
    //If we received 0 from both the children then don't put a camera but return -1
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
