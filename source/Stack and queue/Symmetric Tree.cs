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
    public bool IsSymmetric(TreeNode root) {
        return IsSymmetric(root.left, root.right);
    }
    
    public bool IsSymmetric(TreeNode node1, TreeNode node2){
        if(node1 == null && node2 == null)
            return true;
        if(node1 == null || node2 == null)
            return false;
        if(node1.val != node2.val)
            return false;
        
        return IsSymmetric(node1.left, node2.right) && IsSymmetric(node1.right, node2.left);
    }
   
    // Runtime: 92 ms, faster than 80.09% of C# online submissions for Symmetric Tree.
    // Memory Usage: 25.6 MB, less than 63.76% of C# online submissions for Symmetric Tree.
   public bool IsSymmetricByQueue(TreeNode node){
        if(node == null)
            return true;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(node);
        
        while(queue.Count > 0){
            var list = new List<int?>();
            var count = queue.Count;
            for(int i = 0; i < count; i++){
                var currentNode = queue.Dequeue();
                if(currentNode != null){
                    list.Add(currentNode.val);
                    queue.Enqueue(currentNode.left);
                    queue.Enqueue(currentNode.right);
                }
                else
                    list.Add(null);
                // prevent [1,2,2,null,3,null,3]
            }
            
            for(int i = 0; i < list.Count/2; i++){
                if(list[i] != list[list.Count - 1 - i])
                    return false;
            }
        }
        return true;
    }
}
