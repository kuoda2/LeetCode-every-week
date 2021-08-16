/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public int MaxDepth(Node root) {
        if(root == null)
            return 0;
        
        var queue = new Queue<Node>();
        queue.Enqueue(root);
        var depth = 0;
        while(queue.Count > 0){
            var queueSize = queue.Count;
            for(int i = 0; i < queueSize; i++){
                var node = queue.Dequeue();
                foreach(var childNode in node.children){
                    queue.Enqueue(childNode);
                }
            }
            depth++;
        }
        return depth;
    }
}
