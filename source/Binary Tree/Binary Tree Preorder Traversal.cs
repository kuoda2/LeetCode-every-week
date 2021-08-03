public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        var result = new List<int>();
        preorder(root, result);
        return result;
    }
    
    public void preorder(TreeNode node, List<int> list){
        if(node == null)
            return;
        list.Add(node.val);
        preorder(node.left, list);
        preorder(node.right, list);
    }
}
