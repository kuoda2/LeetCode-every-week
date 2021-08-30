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
    
    Dictionary<int,int> inMap;
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        inMap = new Dictionary<int,int>();
        for(int i = 0; i < inorder.Length; i++){
            inMap[inorder[i]] = i;
        }
        var result = GetNode(inorder, postorder, 0, inorder.Length - 1, 0, postorder.Length -1);
        return result;
    }
    
    public TreeNode GetNode(int[] inorder, int[] postorder, int inFrom, int inTo, int postFrom, int postTo){
        if(postFrom > postTo || inFrom > inTo)
            return null;
        Console.WriteLine(postTo);
        var rootVal = postorder[postTo];
        var inIndex = inMap[rootVal];
        var result = new TreeNode(rootVal);
        result.left = GetNode(inorder, postorder, inFrom, inIndex -1, postFrom, postFrom + inIndex - inFrom -1);
        result.right = GetNode(inorder, postorder, inIndex + 1, inTo, postFrom + inIndex - inFrom, postTo - 1);
        return result;

    }
}
