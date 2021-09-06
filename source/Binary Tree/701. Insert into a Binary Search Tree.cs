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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        if(root == null)
            return new TreeNode(val);
        var curr = root;
        TreeNode pre = null;
        
        while(true)
        {
            if(curr != null){
                pre = curr;
                if(val > curr.val)
                    curr = curr.right;
                else
                    curr = curr.left;
            }
            else
                break;
        }
          if(val > pre.val)
                pre.right = new TreeNode(val);
            else
                pre.left = new TreeNode(val);
        return root;
    }
}
