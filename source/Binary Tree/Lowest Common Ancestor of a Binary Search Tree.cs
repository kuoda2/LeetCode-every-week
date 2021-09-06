/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        while((root.val - p.val) * (root.val - q.val) > 0)
            root = root.val > p.val ? root.left : root.right;
        return root;
    }
    
    public TreeNode LowestCommonAncestor2(TreeNode root, TreeNode p, TreeNode q) {
        
        var stack1 = Postorder(root, p.val);
        var stack2 = Postorder(root, q.val);
        
        while(stack1.Count != stack2.Count){
            if(stack1.Count > stack2.Count)
                stack1.Pop();
            else
                stack2.Pop();
        }
        
        while(stack1.Peek() != stack2.Peek())
        {
            stack1.Pop();
            stack2.Pop();
        }
        return stack1.Peek();
    }
    
    public Stack<TreeNode> Postorder(TreeNode node, int target){
        Stack<TreeNode> stack = new Stack<TreeNode>();
        
        while(true){
            while(node != null){
                stack.Push(node);
                stack.Push(node);
                node = node.left;
            }
            
            if(stack.Count == 0) return stack;
            node = stack.Pop();
            if(stack.Count != 0 && stack.Peek() == node)
                node = node.right;
            else
            {
                if(node.val == target){
                    stack.Push(node);
                    return stack;
                }
                node = null;
            }
        }
    }
}

