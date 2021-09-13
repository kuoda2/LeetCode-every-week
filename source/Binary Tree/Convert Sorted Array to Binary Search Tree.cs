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
    public TreeNode SortedArrayToBST(int[] nums) {
        if(nums.Length == 0)
            return null;
        var index = nums.Length / 2;
        var root = new TreeNode(nums[index]);
        root.left = SortedArrayToBST(nums[0..index++]);
        root.right = SortedArrayToBST(nums[index..]);
        return root;
    }
}
