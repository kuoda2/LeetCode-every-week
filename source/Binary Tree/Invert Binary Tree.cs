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

  // Runtime: 92 ms, faster than 72.56% of C# online submissions for Invert Binary Tree.
  // Memory Usage: 24.8 MB, less than 48.22% of C# online submissions for Invert Binary Tree.
    public TreeNode InvertTree(TreeNode root) {
        if(root == null)
            return root;
        
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        
        while(stack.Count > 0){
            var curr = stack.Pop();
            var left = curr.left;
            curr.left = curr.right;
            curr.right = left;
            
            if(curr.left != null)
                stack.Push(curr.left);
            if(curr.right != null)
                stack.Push(curr.right);
        }
        return root;
    }
    
    // Runtime: 96 ms, faster than 45.01% of C# online submissions for Invert Binary Tree.
    // Memory Usage: 24.9 MB, less than 12.17% of C# online submissions for Invert Binary Tree.
    public TreeNode InvertTree2(TreeNode root) {
        if(root == null)
            return root;
        
        TreeNode left = InvertTree2(root.left);
        TreeNode right = InvertTree2(root.right);
        
        root.left = right;
        root.right = left; 
        
        return root;
        
    }
}
