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
    public bool IsValidBST(TreeNode root) {
       return Valid(root);
    }
    public bool Valid(TreeNode currNode){
        
        if(CheckLeft(currNode)){
            if(CheckRight(currNode))
                return true;
        }
        return false;
    }
    
    public bool CheckRight(TreeNode node){
        if(node.left == null || node.val > node.left.val)
            return true;
        return false;
    }
    
    public bool CheckLeft(TreeNode node){
          if(node.right == null || node.val < node.right.val)
            return true;
        return false;
    }
}
