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
    public IList<string> BinaryTreePaths(TreeNode root) {
        var result = new List<string>();
        List<int> list = new List<int>();
        Helper(list, root, result);
        return result;
    }
    
    public void Helper(List<int> list, TreeNode node, List<string> result){
        if(node == null)
            return;
        list.Add(node.val);
     
        Helper(list, node.left, result);
        Helper(list, node.right, result);

        if(node.left == null && node.right == null){
            result.Add(string.Join("->", list));
        }
        list.RemoveAt(list.Count - 1);
        
    }
}
