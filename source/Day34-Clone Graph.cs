/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    Dictionary<int,Node> dic = new Dictionary<int,Node>();
    public Node CloneGraph(Node node) {
        var ans = Clone(node);
        return ans;
    }
    
    public Node Clone(Node node){
        if(node == null)
            return null;
        if(dic.ContainsKey(node.val))
            return dic[node.val];
        Node newNode = new Node(node.val,new List<Node>());
        dic[node.val] = newNode;
        foreach(var item in node.neighbors){
            newNode.neighbors.Add(Clone(item));
        }
        return newNode;
    }
}
