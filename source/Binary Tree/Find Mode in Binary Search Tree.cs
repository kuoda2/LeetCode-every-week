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
    List<int> result = new List<int>();
    TreeNode preNode = null;
    int maxCount = 1;
    int currCount = 1;
    public int[] FindMode(TreeNode root) {
        Inorder(root);
        return result.ToArray();
    }
    
    public void Inorder(TreeNode node){
        if(node == null)
            return;
        Inorder(node.left);
        
        if(preNode != null){
            if(preNode.val == node.val)
                currCount++;
            else
                currCount = 1;
        }
        
        preNode = node;
        
        if(currCount > maxCount){
            maxCount = currCount;
            result.Clear();
            result.Add(node.val);
        }
        else if(currCount == maxCount){
            result.Add(node.val);
        }
        
        Inorder(node.right);
    }
}
