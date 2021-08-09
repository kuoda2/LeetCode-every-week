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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var dic = new Dictionary<int,List<int>>();
        GetNodeVal(root, 0, dic);
        var result = new List<IList<int>>();
        foreach(var item in dic.Keys){
            result.Add(dic[item]);
        }
        return result;
    }
    public void GetNodeVal(TreeNode node, int level, Dictionary<int,List<int>> dic){
        if(node == null)
            return;
        if(!dic.ContainsKey(level))
            dic[level] = new List<int>();
        dic[level].Add(node.val);
        level++;
        GetNodeVal(node.left, level, dic);
        GetNodeVal(node.right, level, dic);
    }
}
