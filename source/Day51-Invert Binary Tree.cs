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
    public TreeNode InvertTree(TreeNode root) {
        if(root == null) return null;
        TreeNode result = new TreeNode(root.val);
        result = DFS(root, result);
        return result;
    }
    
    public TreeNode DFS(TreeNode node, TreeNode newNode){
        if(node == null)
            return node;
        if(node.left != null)
        newNode.right = new TreeNode(node.left.val);
        DFS(node.left, newNode.right);
        if(node.right != null)
        newNode.left = new TreeNode(node.right.val);
        DFS(node.right, newNode.left);
        return newNode;
    }
}


public class Solution2 {
    public TreeNode InvertTree(TreeNode root) {
        if(root == null)
            return root;
        
        TreeNode left = InvertTree(root.left);
        TreeNode right = InvertTree(root.right);
        
        root.left = right;
        root.right = left; 
        
        return root;
        
    }
}
