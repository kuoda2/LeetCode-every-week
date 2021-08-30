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
    Dictionary<int, int> map;
    public TreeNode ConstructMaximumBinaryTree(int[] nums) {
        
        map = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            map[nums[i]] = i;
        }
        var result = GetNode(0, nums.Length -1, nums);
        return result;
    }
    
    public TreeNode GetNode(int indexFrom, int indexTo, int[] nums){
        var newNums = nums.Skip(indexFrom).Take(indexTo - indexFrom + 1);
        if(newNums.Count() == 0)
            return null;
        var max = newNums.Max();
        var maxIndex = map[max];
        var result = new TreeNode();
        result.val = max;
        result.left = GetNode(indexFrom, maxIndex - 1, nums);
        result.right = GetNode(maxIndex + 1, indexTo, nums);
        return result;
        
    }
}
