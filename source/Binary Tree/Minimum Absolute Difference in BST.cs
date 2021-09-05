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
    
    
    public int GetMinimumDifference(TreeNode root) {
        var result = int.MaxValue;
        var stack = new Stack<TreeNode>();
        var curr = root;
        TreeNode preNode = null;
        while(curr != null || stack.Count > 0)
        {
            if(curr != null){
                stack.Push(curr);
                curr = curr.left;
            }
            else{
                curr = stack.Pop();
                if(preNode != null)
                    result = Math.Min(result, curr.val - preNode.val);
                preNode = curr;
                curr = curr.right;
            }
        }
        return result;
    }
}
