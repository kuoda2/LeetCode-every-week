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
    public int FindBottomLeftValue(TreeNode root) {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        
        queue.Enqueue(root);
        var curr =root;
        while(queue.Count > 0){
            var count  = queue.Count;
            for(int i=0; i< count; i++){
                curr = queue.Dequeue();
                if(curr.right != null)
                    queue.Enqueue(curr.right);
                if(curr.left != null)
                    queue.Enqueue(curr.left);
            }
        }
        return curr.val;
    }
}
