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
    public TreeNode SearchBST(TreeNode root, int val) {
       return Iteration(root, val);
    }
    
    // Iteration
    // Runtime: 180 ms, faster than 8.66% of C# online submissions for Search in a Binary Search Tree.
    // Memory Usage: 34.6 MB, less than 50.39% of C# online submissions for Search in a Binary Search Tree.
    public TreeNode Iteration(TreeNode node, int val){
        while(node != null && node.val != val){
            node = val < node.val ? node.left : node.right;
        }
        return node;
    }
    
    // Recursion
    // Runtime: 154 ms, faster than 14.17% of C# online submissions for Search in a Binary Search Tree.
    // Memory Usage: 34.6 MB, less than 50.39% of C# online submissions for Search in a Binary Search Tree.
    public TreeNode Recursion(TreeNode node, int val){
        if(node == null) return node;
        if(node.val == val){
            return node;
        }
        else{
            return val < node.val ? Recursion(node.left, val) : Recursion(node.right, val);
        }
    }
      
    // BFS
    // Runtime: 195 ms, faster than 5.71% of C# online submissions for Search in a Binary Search Tree.
    // Memory Usage: 34.6 MB, less than 50.39% of C# online submissions for Search in a Binary Search Tree.
    public TreeNode BFS(TreeNode root, int val){
        if(root == null)
            return null;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count > 0){
            var node = queue.Dequeue();
            if(node.val == val)
                return node;
            if(val < node.val && node.left != null)
                queue.Enqueue(node.left);
            else if(val > node.val && node.right != null)
                queue.Enqueue(node.right);
        }
        return null;
    }
}
