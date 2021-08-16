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
    public int MaxDepth(TreeNode root) {
       return GetDepth(root, 0);
    }
    //Runtime: 84 ms, faster than 99.07% of C# online submissions for Maximum Depth of Binary Tree.
    //Memory Usage: 26.1 MB, less than 50.34% of C# online submissions for Maximum Depth of Binary Tree.
    public int GetDepth(TreeNode node, int depth){
        if(node == null)
            return depth;
        depth++;
        return Math.Max(GetDepth(node.left, depth), GetDepth(node.right, depth));
    }
    //Runtime: 88 ms, faster than 95.92% of C# online submissions for Maximum Depth of Binary Tree.
    //Memory Usage: 26 MB, less than 50.34% of C# online submissions for Maximum Depth of Binary Tree.
    public int GetDepthIteration(TreeNode root){
        return root == null ? 0 :  (1 + Math.Max(GetDepthIteration(root.left), GetDepthIteration(root.right)));
    }
}
