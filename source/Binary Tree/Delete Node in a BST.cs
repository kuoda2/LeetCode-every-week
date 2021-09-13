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
    public TreeNode DeleteNode(TreeNode root, int key) {
        if(root == null)
            return root;
        var curr = root;
        TreeNode preNode = null;
        bool isRightNode = false;
        while(curr != null && curr.val != key){
            preNode = curr;
            if(curr.val > key){
                curr = curr.left;
                isRightNode = false;
            }
            else{
                curr = curr.right;
                isRightNode = true;
            }
        }
        if( curr == null)
            return root;
        if(curr.left == null && curr.right == null)
        {
            if(preNode == null)
                return null;
            if(isRightNode)
                preNode.right = null;
            else
                preNode.left = null;
        }
        else if(curr.left == null){
            if(preNode == null)
                return curr.right;
            if(isRightNode)
                preNode.right = curr.right;
            else
                preNode.left = curr.right;
        }else if(curr.right == null){
            if(preNode == null)
                return curr.left;
            if(isRightNode)
                preNode.right = curr.left;
            else
                preNode.left = curr.left;
        }
        else{
            TreeNode nodeBeforeRightest = null;
            var rightestNode = curr.left;
            if(rightestNode.left == null && rightestNode.right == null){
                curr.val = rightestNode.val;
                curr.left = null;
            }
            else{
                while(rightestNode.right != null){
                    nodeBeforeRightest = rightestNode;
                    rightestNode = rightestNode.right;
                }
                if(nodeBeforeRightest != null){
                    nodeBeforeRightest.right = rightestNode.left;
                    curr.val = rightestNode.val;
                }
                else{
                    curr.val = rightestNode.val;
                    curr.left = rightestNode.left;
                }
            }
        }
        return root;
    }
}
