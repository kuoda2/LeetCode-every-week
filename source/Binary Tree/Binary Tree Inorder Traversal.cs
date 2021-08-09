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
// Recursive
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        var result = new List<int>();
        Inorder(root, result);
        return result;
    }
    public void Inorder(TreeNode node,List<int> result){
        if(node == null) return;
        Inorder(node.left, result);
        result.Add(node.val);
        Inorder(node.right, result);
    }
}

// stack
public class Solution2 {
    public IList<int> InorderTraversal(TreeNode root) {
        var result = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        var currentNode = root;
        while(currentNode != null || stack.Count > 0){
            while(currentNode != null){
                stack.Push(currentNode);
                currentNode = currentNode.left;
            }
            currentNode = stack.Pop();
            result.Add(currentNode.val);
            currentNode = currentNode.right;
        }
        return result;
    }
}
