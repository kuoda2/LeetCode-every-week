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
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        var result = new List<IList<int>>();
        var nums = new List<int>();
        DFS(root, 0, targetSum, nums, result);
        return result;
    }
    
    
    public void DFS(TreeNode node, int preSum, int targetSum,List<int> nums, List<IList<int>> result){
        if(node == null)
            return;
        
        nums.Add(node.val);
        preSum += node.val;
        
        DFS(node.left, preSum, targetSum, nums, result);
        DFS(node.right, preSum, targetSum, nums, result);
        
        if(node.left == null && node.right == null && preSum == targetSum)
            result.Add(nums.ToList());
        
        nums.RemoveAt(nums.Count - 1);
    }
}
