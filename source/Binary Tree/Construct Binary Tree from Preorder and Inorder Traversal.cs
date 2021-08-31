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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        var inMap = new Dictionary<int,int>();
        for(int i = 0; i < inorder.Length; i++){
            inMap[inorder[i]] = i;
        }
        var result = GetNode(preorder, inorder, inMap, 0, inorder.Length -1, 0, preorder.Length - 1);
        return result;
    }
    
    public TreeNode GetNode(int[] preorder, int[] inorder, Dictionary<int,int> inMap, int inFrom, int inTo, int preFrom, int preTo){
        if(preFrom > preTo || inFrom > inTo)
            return null;
        
        var node = new TreeNode(preorder[preFrom]);
        var inIndex = inMap[node.val];
        node.left = GetNode(preorder, inorder, inMap, inFrom, inIndex - 1, preFrom + 1, preFrom + 1 + (inIndex - inFrom - 1));
        node.right = GetNode(preorder, inorder, inMap, inIndex +1, inTo, preFrom + 1 + (inIndex - inFrom),preTo);
        return node;
        
    }
}
