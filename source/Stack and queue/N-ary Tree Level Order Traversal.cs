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
    public IList<IList<int>> LevelOrder(Node root) {
        var result = new List<IList<int>>();
        if(root == null)
            return result;
        var queue = new Queue<Node>();
        queue.Enqueue(root);
        while(queue.Count > 0){
            var list = new List<int>();
            var count = queue.Count;
            for(int i = 0; i < count ; i++){
                var node = queue.Dequeue();
                list.Add(node.val);
                foreach(var child in node.children){
                    queue.Enqueue(child);
                }
            }
            result.Add(list);
        }
        return result;
    }
}
