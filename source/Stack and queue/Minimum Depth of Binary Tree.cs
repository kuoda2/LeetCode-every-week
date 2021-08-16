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
    public int MinDepth(TreeNode root) {
        if(root == null)
            return 0;
        
        var depth = 1;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while(queue.Count > 0){
            var queueSize = queue.Count;
            for(int i = 0; i < queueSize; i ++){
                var node = queue.Dequeue();
                if(node.left == null && node.right == null)
                    return depth;
                if(node.left != null)
                   queue.Enqueue(node.left);
                if(node.right != null)
                    queue.Enqueue(node.right);
            }
            depth++;
        }
        return depth;
    }
}
