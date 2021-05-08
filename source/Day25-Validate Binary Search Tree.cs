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
        
        if(Valid(root.left, root))
            if(Valid(root.right, root))
                return true;
       return false;
    }
    public bool Valid(TreeNode currNode, TreeNode lastNode){
        
        if(CheckLeft(currNode, lastNode)){
            if(CheckRight(currNode, lastNode))
                return true;
        }
        return false;
    }
    
    public bool CheckLeft(TreeNode node, TreeNode lastNode){
        if(node == null || node.left == null)
            return true;
        if(node.val > node.left.val && lastNode.val < node.left.val)
                return true;
        return false;
    }
    
    public bool CheckRight(TreeNode node, TreeNode lastNode){
        if(node == null || node.right == null)
            return true;
        if(node.val < node.right.val && lastNode.val > node.right.val)
            return true;
        return false;
    }
}
